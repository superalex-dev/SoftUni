using Microsoft.EntityFrameworkCore;
using MyCalendar.Data;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MyCalendar
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new MyCalendarDbContext();

            var projectDir = GetProjectDirectory();
            using (var transaction = context.Database.BeginTransaction())
            {
                transaction.Rollback();
            }
            ResetDatabase(context, shouldDropDatabase: true);
            ImportEntities(context, projectDir + @"Datasets/");

            Console.WriteLine(UserWithTheMostEvents(context));
        }
        public static string UserWithTheMostEvents(MyCalendarDbContext context)
        {
            var userWithMostEvents = context.Users .Select(u => new
                {
                    u.Name,
                    EventCount = u.Invites.Count,
                    Events = u.Invites.Select(i => i.Event.Name).OrderBy(n => n).ToList()
                })
                .OrderByDescending(u => u.EventCount)
                .FirstOrDefault();

            StringBuilder sb = new StringBuilder();

            if (userWithMostEvents != null)
            {
                sb.AppendLine($"The user with the most events - {userWithMostEvents.Name.Trim()}");
                foreach (var eventName in userWithMostEvents.Events)
                {
                    sb.AppendLine(eventName.Trim());
                }
            }

            return sb.ToString().Trim();
        }
        private static void ImportEntities(MyCalendarDbContext context, string baseDir)
        {

            var employees =
             DataProcessor.Deserializer.ImportData(context,
                 File.ReadAllText(baseDir + "data.json"));

            PrintResultOfDataImport(employees);
        }
        private static void ResetDatabase(MyCalendarDbContext context, bool shouldDropDatabase = false)
        {
            if (shouldDropDatabase)
            {
                context.Database.EnsureDeleted();
            }

            if (context.Database.EnsureCreated())
            {
                return;
            }

            var disableIntegrityChecksQuery = "EXEC sp_MSforeachtable @command1='ALTER TABLE ? NOCHECK CONSTRAINT ALL'";
            context.Database.ExecuteSqlRaw(disableIntegrityChecksQuery);

            var deleteRowsQuery = "EXEC sp_MSforeachtable @command1='SET QUOTED_IDENTIFIER ON;DELETE FROM ?'";
            context.Database.ExecuteSqlRaw(deleteRowsQuery);

            var enableIntegrityChecksQuery =
                "EXEC sp_MSforeachtable @command1='ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'";
            context.Database.ExecuteSqlRaw(enableIntegrityChecksQuery);

            var reseedQuery =
                "EXEC sp_MSforeachtable @command1='IF OBJECT_ID(''?'') IN (SELECT OBJECT_ID FROM SYS.IDENTITY_COLUMNS) DBCC CHECKIDENT(''?'', RESEED, 0)'";
            context.Database.ExecuteSqlRaw(reseedQuery);
        }
        private static string GetProjectDirectory()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var directoryName = Path.GetFileName(currentDirectory);
            var relativePath = directoryName.StartsWith("netcoreapp") ? @"../../../" : string.Empty;

            return relativePath;
        }
        private static void PrintResultOfDataImport(string entityOutput)
        {
            Console.WriteLine(entityOutput);
        }
    }
}

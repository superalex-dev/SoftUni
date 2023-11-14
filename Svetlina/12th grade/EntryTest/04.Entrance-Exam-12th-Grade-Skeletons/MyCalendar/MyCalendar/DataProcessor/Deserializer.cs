using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyCalendar.Data;
using MyCalendar.Data.Entities;
using MyCalendar.DataProcessor.ImportDto;
using Newtonsoft.Json;

namespace MyCalendar.DataProcessor
{

    public class Deserializer
    {
        private const string SuccessfullyImportedUsersCount
            = "Successfully imported {0} users.";
        private const string SuccessfullyImportedUsers
            = "Successfully imported user - {0} with {1} invites for events.";

        public static string ImportData(MyCalendarDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportUserDto[] userDtos = JsonConvert.DeserializeObject<ImportUserDto[]>(jsonString);

            List<User> users = new List<User>();

            List<Event> events = new List<Event>();

            foreach (ImportUserDto userDto in userDtos)
            {
                User p = new User()
                {
                    Name = userDto.Name,
                    Calendar = new Calendar { Name = $"{userDto.Name + "Calendar"}" }
                };
                foreach (ImportEventDto eventDto in userDto.Events)
                {
                    Event t = events.FirstOrDefault(e => e.Name == eventDto.Name);

                    if (t == null)
                    {
                        t = new Event()
                        {
                            Name = eventDto.Name,
                            Location = eventDto.Location,
                            StartEvent = Convert.ToDateTime(eventDto.StartEvent),
                            EndEvent = Convert.ToDateTime(eventDto.EndEvent)
                        };
                        events.Add(t);
                    }

                    Invite i = new Invite()
                    {
                        Event = t,
                        User = p
                    };

                    p.Invites.Add(i);
                }

                users.Add(p);
                sb.AppendLine(String.Format(SuccessfullyImportedUsers, p.Name, p.Invites.Count));
            }

            context.Users.AddRange(users);
            context.SaveChanges();

            sb.AppendLine(String.Format(SuccessfullyImportedUsersCount, users.Count));
            return sb.ToString().TrimEnd();
        }
    }
}
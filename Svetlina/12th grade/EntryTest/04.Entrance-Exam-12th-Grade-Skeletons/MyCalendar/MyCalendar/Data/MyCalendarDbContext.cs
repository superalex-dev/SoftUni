using Microsoft.EntityFrameworkCore;
using MyCalendar.Data.Entities;

namespace MyCalendar.Data
{
    public class MyCalendarDbContext : DbContext
    {
        public MyCalendarDbContext()
        {
        }

        public MyCalendarDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Calendar;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invite>()
                .HasKey(i => new { i.UserId, i.EventId });

            modelBuilder.Entity<Invite>()
                .HasOne(i => i.User)
                .WithMany(u => u.Invites)
                .HasForeignKey(i => i.UserId);

            modelBuilder.Entity<Invite>()
                .HasOne(i => i.Event)
                .WithMany(e => e.Invites)
                .HasForeignKey(i => i.EventId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Calendar)
                .WithOne(c => c.User)
                .HasForeignKey<Calendar>(c => c.UserId);
        }
    }
}
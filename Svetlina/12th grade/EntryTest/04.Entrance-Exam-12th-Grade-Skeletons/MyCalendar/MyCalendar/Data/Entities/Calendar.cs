using System.ComponentModel.DataAnnotations;

namespace MyCalendar.Data.Entities
{
    public class Calendar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCalendar.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Calendar Calendar { get; set; }
        public ICollection<Invite> Invites { get; set; } = new List<Invite>();
    }
}

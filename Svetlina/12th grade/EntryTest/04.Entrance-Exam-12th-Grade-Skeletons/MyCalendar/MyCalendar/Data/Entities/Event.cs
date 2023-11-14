using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCalendar.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime StartEvent { get; set; }
        public DateTime EndEvent { get; set; }
        public ICollection<Invite> Invites { get; set; } = new List<Invite>();
    }
}

using System;
using System.Collections.Generic;

namespace Svetlinagram.Models
{
    public partial class Profile
    {
        public Profile()
        {
            MessageReceivers = new HashSet<Message>();
            MessageSenders = new HashSet<Message>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Message> MessageReceivers { get; set; }
        public virtual ICollection<Message> MessageSenders { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}

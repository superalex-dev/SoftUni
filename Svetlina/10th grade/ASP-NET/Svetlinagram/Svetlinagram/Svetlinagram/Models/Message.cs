using System;
using System.Collections.Generic;

namespace Svetlinagram.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Message1 { get; set; } = null!;

        public virtual Profile Receiver { get; set; } = null!;
        public virtual Profile Sender { get; set; } = null!;
    }
}

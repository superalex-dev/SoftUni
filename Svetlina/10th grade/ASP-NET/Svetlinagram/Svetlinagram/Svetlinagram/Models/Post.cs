using System;
using System.Collections.Generic;

namespace Svetlinagram.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Post1 { get; set; } = null!;
        public int UserId { get; set; }

        public virtual Profile User { get; set; } = null!;
    }
}

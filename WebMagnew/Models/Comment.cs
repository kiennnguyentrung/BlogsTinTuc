using System;
using System.Collections.Generic;

#nullable disable

namespace WebMagnew.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Contents { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? AccountId { get; set; }
        public int? PostId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Post Post { get; set; }
    }
}

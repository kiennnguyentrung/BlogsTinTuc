using System;
using System.Collections.Generic;

#nullable disable

namespace WebMagnew.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public string Tilte { get; set; }
        public string Scontent { get; set; }
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public bool Published { get; set; }
        public string Alias { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? AccountId { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
        public bool IsHot { get; set; }
        public bool IsNewFeed { get; set; }
        public int? Views { get; set; }
        public string MetaKey { get; set; }
        public string MetaDesc { get; set; }
        public int? CatId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Category Cat { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

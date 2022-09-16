using System;
using System.Collections.Generic;

#nullable disable

namespace WebMagnew.Models
{
    public partial class Page
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Alias { get; set; }
        public string Contents { get; set; }
        public bool Active { get; set; }
        public string Tilte { get; set; }
        public string Thumb { get; set; }
    }
}

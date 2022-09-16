
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMagnew.Models;

namespace WebMagnew.Controllers
{
    
    public class SearchController : Controller
    {
        private readonly dbBlogsContext _context;

        public SearchController(dbBlogsContext context)
        {
            _context = context;
        }
        public string CurrentFilter { get; set; }
        [HttpPost]
        public async Task<IActionResult> FindBaiViet(string SearchString)
        {
            var keyword = from m in _context.Posts
                          select m;
            if (!String.IsNullOrEmpty(SearchString))
                keyword = keyword.Where(s => s.Tilte.Contains(SearchString) || s.Contents.Contains(SearchString));
            return View(await keyword.ToListAsync());
        }
    }
}

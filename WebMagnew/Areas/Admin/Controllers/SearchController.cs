using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMagnew.Models;

namespace WebMagnew.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly dbBlogsContext _context;

        public SearchController(dbBlogsContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult FindBaiViet(string keyword)
        {
            List<Post> ls = new List<Post>();
            //if (keyword != null && keyword.Trim().Length > 3)
            //{
            //    var ls = _context.Posts
            //        .Include(x => x.Cat)
            //        .AsNoTracking().Where(x => x.Tilte.Contains(keyword) || x.Contents.Contains(keyword))
            //        .OrderByDescending(x => x.CreateAt).ToList();
            //    return PartialView("ListBaiVietSearchPartial", ls);
            //}
            //else
            //{
            //    return PartialView("ListBaiVietSearchPartial", null);
            //}
            if(string.IsNullOrEmpty(keyword) || keyword.Length <1)
            {
                return PartialView("ListBaiVietSearchPartial", null);
            }
            ls = _context.Posts.AsNoTracking()
                    .Include(x => x.Cat)
                    .Where(x => x.Tilte.Contains(keyword) || x.Contents.Contains(keyword))
                    .OrderByDescending(x => x.CreateAt).Take(6).ToList();
            if(ls== null)
            {
                return PartialView("ListBaiVietSearchPartial", null);
            }
            else
            {
                return PartialView("ListBaiVietSearchPartial", ls);
            }
            
        }
    }
}

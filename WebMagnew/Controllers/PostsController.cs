using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebMagnew.Models;
using WebMagNews.Helpers;

namespace WebMagnew.Controllers
{
    public class PostsController : Controller
    {
        private readonly dbBlogsContext _context;

        public PostsController(dbBlogsContext context)
        {
            _context = context;
        }

        // GET: Posts
        [Route("{Alias}", Name = "ListTin")]
        public IActionResult List( string Alias, int? page)
        {
            if (string.IsNullOrEmpty(Alias)) return RedirectToAction("Home", "Index");
            var danhmuc = _context.Categories.FirstOrDefault(x => x.Alias == Alias);
            if (danhmuc == null) return RedirectToAction("Home", "Index");

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = Utilities.PAGE_SIZE;

            List<Post> lsPosts = new List<Post>();

            if (!string.IsNullOrEmpty(Alias))
            {
                lsPosts = _context.Posts
               .Include(x => x.Cat).Where(x=>x.CatId == danhmuc.CatId && x.IsNewFeed == true)
                 .AsNoTracking()
                 .OrderByDescending(x => x.CreateAt).ToList();
            }
            else
            {
                lsPosts = _context.Posts
               .Include(x => x.Cat )
                 .AsNoTracking()
                 .OrderByDescending(x => x.CreateAt).ToList();
            }
           
            //sắp xếp
            PagedList<Post> models = new PagedList<Post>(lsPosts.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            ViewBag.DanhMuc = danhmuc;
            return View(models);
        }

        // GET: Posts/Details/5
        [Route("/{Alias}.html", Name ="PostsDetails")]
        public async Task<IActionResult> Details(string Alias)
        {
            if (string.IsNullOrEmpty(Alias))
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Account)
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.Alias == Alias );
            if (post == null)
            {
                return NotFound();
            }
            post.Views++;
            _context.SaveChanges();
            var lsBaiVietLienQuan = _context.Posts.AsNoTracking().Where(x => x.Published == true && x.IsNewFeed == true)
                .Take(3).OrderByDescending(x => x.CreateAt).ToList();
            ViewBag.BaiVietLienQuan = lsBaiVietLienQuan;
            return View(post);
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(int PostId, Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();

                return View("Details", new Comment { PostId = comment.PostId });
            }
            return View("Posts/Details");
        }
        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }
    }
}

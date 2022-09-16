using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebMagnew.Areas.Admin.Models;
using WebMagnew.Models;
using WebMagNews.Helpers;

namespace WebMagnew.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize()]
    public class PostsController : Controller
    {
        private readonly dbBlogsContext _context;

        public PostsController(dbBlogsContext context)
        {
            _context = context;
        }

        // GET: Admin/Posts
        public IActionResult Index( int? page, int CatID = 0)
        {
            //kiểm tra quyền truy cập
            //if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            //var taikhoanID = HttpContext.Session.GetString("AccountId");
            //if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });

            //var account = _context.Accounts.AsNoTracking().FirstOrDefaultAsync(x => x.AccountId == int.Parse(taikhoanID));
            //if (account == null) return NotFound();

            List<Post> lsPosts = new List<Post>();

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = Utilities.PAGE_SIZE;

            if (CatID != 0)
            {

                lsPosts = _context.Posts
                .AsNoTracking()
                .Where(x => x.CatId == CatID)
                .Include(x => x.Cat)
                .OrderByDescending(x => x.PostId).ToList();
            }    
            else
            {
                lsPosts = _context.Posts
                 .AsNoTracking()
                 .Include(x => x.Cat)
                 .OrderByDescending(x => x.PostId).ToList();
            }
            PagedList<Post> models = new PagedList<Post>(lsPosts.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            ViewBag.CurrentCatID = CatID;
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", CatID);
            return View(models);
        }
        //[HttpPost]
        //public async Task<IActionResult> FindBaiViet(/*string PostCat,*/ string SearchString)
        //{
        //    //IQueryable<string> genreQuery = from m in _context.Posts
        //    //                                orderby m.Cat.CatName
        //    //                                select m.Cat.CatName;
        //    var keyword = from m in _context.Posts
        //                  select m;
        //    if (!String.IsNullOrEmpty(SearchString))
        //        keyword = keyword.Where(s => s.Tilte.Contains(SearchString) || s.Contents.Contains(SearchString));
        //    //if (!string.IsNullOrEmpty(PostCat))
        //    //{
        //    //    keyword = keyword.Where(x => x.Cat.CatName == PostCat);
        //    //}
        //    //var PostCatVM = new CatPostViewModel
        //    //{
        //    //    Cat = new SelectList(await genreQuery.Distinct().ToListAsync()),
        //    //    Posts = await keyword.ToListAsync()
        //    //};
        //    return View(await keyword.ToListAsync());
        //    //return View(PostCatVM);
        //}


        // GET: Admin/Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Account)
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/Posts/Create
        public IActionResult Create()
        {
            //kiểm tra quyền truy cập
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId");
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");
            //ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");
            return View();
        }

        // POST: Admin/Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Tilte,Scontent,Contents,Thumb,Published,Alias,CreateAt,AccountId,Author,Tag,CatId,IsHot,IsNewFeed,Views,MetaKey,MetaDesc")] Post post,Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });

            var account = _context.Accounts.AsNoTracking().FirstOrDefaultAsync(x => x.AccountId == int.Parse(taikhoanID));
            if (account == null) return NotFound();

            if (ModelState.IsValid)
            {
                int accountId = (await account).AccountId;
                post.AccountId = accountId;
                string fullName = (await account).FullName;
                post.Author = fullName;
                if (post.CatId == null) post.CatId = 1;
                post.Alias = Utilities.SEOUrl(post.Tilte);
                post.Views = 0;
                if(fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string Newname = Utilities.SEOUrl(post.Tilte) + extension;
                    post.Thumb = await Utilities.UploadFile(fThumb, @"posts\", Newname.ToLower());
                }    
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", post.AccountId);
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", post.CatId);
            return View(post);
        }

        // GET: Admin/Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", post.AccountId);
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", post.CatId);
            return View(post);
        }

        // POST: Admin/Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Tilte,Scontent,Contents,Thumb,Published,Alias,CreateAt,AccountId,Author,Tag,CatId,IsHot,IsNewFeed,Views,MetaKey,MetaDesc")] Post post, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != post.PostId)
            {
                return NotFound();
            }
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });

            var account = _context.Accounts.AsNoTracking().FirstOrDefaultAsync(x => x.AccountId == int.Parse(taikhoanID));
            if (account == null) return NotFound();

            if((await account).RoleId != 1)
            {
                if(post.AccountId != (await account).AccountId) return RedirectToAction(nameof(Index));
            }    
            
            
            if (ModelState.IsValid)
            {
                try
                {
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string Newname = Utilities.SEOUrl(post.Tilte) + extension;
                        post.Thumb = await Utilities.UploadFile(fThumb, @"posts\", Newname.ToLower());
                    }
                    post.Alias = Utilities.SEOUrl(post.Tilte);
                    post.AccountId = (await account).AccountId;
                    string fullName = (await account).FullName;
                    post.Author = fullName;
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", post.AccountId);
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", post.CatId);
            return View(post);
        }

        // GET: Admin/Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Account)
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Admin/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMagnew.Models;
using WebMagNews.Enums;

namespace WebMagnew.Controllers.Components
{
    public class LatestPostsViewComponent : ViewComponent
    {
        private readonly dbBlogsContext _context;
        private IMemoryCache _memoryCahe;
        public LatestPostsViewComponent(dbBlogsContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCahe = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var tinLatestPosts = _memoryCahe.GetOrCreate(CacheKeys.LatestPosts, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(tinLatestPosts);
        }

        public List<Post> GetlsCategories()
        {
            List<Post> lstinlatest = new List<Post>();
            lstinlatest = _context.Posts.AsNoTracking().Where(x => x.Published == true && x.IsNewFeed == true)
                .OrderByDescending(x => x.CreateAt).ToList();
            return lstinlatest;
        }
    }
}

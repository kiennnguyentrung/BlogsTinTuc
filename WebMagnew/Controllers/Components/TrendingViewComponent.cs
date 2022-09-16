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
    public class TrendingViewComponent : ViewComponent
    {
        private readonly dbBlogsContext _context;
        private IMemoryCache _memoryCahe;
        public TrendingViewComponent(dbBlogsContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCahe = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var trending = _memoryCahe.GetOrCreate(CacheKeys.Trending, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(trending);
        }

        public List<Post> GetlsCategories()
        {
            List<Post> lsttrending = new List<Post>();
            lsttrending = _context.Posts.AsNoTracking().Where(x => x.Published == true && x.IsHot == true && x.IsNewFeed == true)
                .OrderByDescending(x => x.Views).Take(6).ToList();
            return lsttrending;
        }
    }
}

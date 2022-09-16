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
    public class PopularViewComponent: ViewComponent
    {
        private readonly dbBlogsContext _context;
        private IMemoryCache _memoryCahe;
        public PopularViewComponent(dbBlogsContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCahe = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var _tinseo = _memoryCahe.GetOrCreate(CacheKeys.Popular, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(_tinseo);
        }

        public List<Post> GetlsCategories()
        {
            List<Post> lstinpopular = new List<Post>();
            lstinpopular = _context.Posts.AsNoTracking().Where(x => x.Published == true && x.IsNewFeed == true)
                .OrderByDescending(x => x.Views).Take(4).ToList();
            return lstinpopular;
        }
    }
}


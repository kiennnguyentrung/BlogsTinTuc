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
    public class RecentViewComponent : ViewComponent
    {

        private readonly dbBlogsContext _context;
        private IMemoryCache _memoryCahe;
        public RecentViewComponent(dbBlogsContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCahe = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var _tinrecent = _memoryCahe.GetOrCreate(CacheKeys.Recent, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(_tinrecent);
        }

        public List<Post> GetlsCategories()
        {
            List<Post> lstinrecent = new List<Post>();
            lstinrecent = _context.Posts.AsNoTracking().Where(x => x.Published == true && x.IsNewFeed == true)
                .OrderByDescending(x => x.CreateAt).Take(4).ToList();
            return lstinrecent;
        }
    }
}


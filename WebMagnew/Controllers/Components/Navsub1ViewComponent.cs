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
    public class Navsub1ViewComponent : ViewComponent
    {

        private readonly dbBlogsContext _context;
        private IMemoryCache _memoryCahe;
        public Navsub1ViewComponent(dbBlogsContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCahe = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var _danhmuccons = _memoryCahe.GetOrCreate(CacheKeys.Categories, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(_danhmuccons);
        }

        public List<Category> GetlsCategories()
        {
            List<Category> lstincons = new List<Category>();
            lstincons = _context.Categories.AsNoTracking()
                .Where(x => x.Pulished == true && x.Levels == 2)
                .OrderBy(x => x.Parents == 2)
                .ToList();
            return lstincons;
        }
    }
}

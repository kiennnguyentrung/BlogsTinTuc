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
    public class CategoriesViewComponent: ViewComponent
    {
        private readonly dbBlogsContext _context;
        private IMemoryCache _memoryCahe;
        public CategoriesViewComponent(dbBlogsContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCahe = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var lsDanhMuc = _memoryCahe.GetOrCreate(CacheKeys.Categories, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(lsDanhMuc);
        }

        public List<Category> GetlsCategories()
        {
            List<Category> lstins = new List<Category>();
            lstins = _context.Categories.AsNoTracking().Where(x => x.Pulished == true)
                .OrderBy(x => x.Ordering).ToList();
            return lstins;
        }
    }
}

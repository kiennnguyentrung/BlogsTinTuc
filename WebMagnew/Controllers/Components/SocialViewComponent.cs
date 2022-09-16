using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMagnew.ModelView;
using WebMagNews.Enums;

namespace WebMagnew.Controllers.Components
{
    public class SocialViewComponent: ViewComponent
    {
        private readonly IConfiguration _config;
        private IMemoryCache _memoryCahe;
        public SocialViewComponent(IConfiguration config, IMemoryCache memoryCache)
        {
            _config = config;
            _memoryCahe = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var _social = _memoryCahe.GetOrCreate(CacheKeys.Social, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsSocials();
            });
            return View(_social);
        }

        public SocialVM GetlsSocials()
        {
            SocialVM socialVM = new SocialVM();
            socialVM.Facebook = _config.GetValue<string>("SocialLinks:facebook");
            socialVM.Twitter = _config.GetValue<string>("SocialLinks:facebook");
            socialVM.Instagram = _config.GetValue<string>("SocialLinks:facebook");
            socialVM.Pinterest = _config.GetValue<string>("SocialLinks:facebook");
            socialVM.Youtube= _config.GetValue<string>("SocialLinks:facebook");
            return socialVM;
        }
    }
}

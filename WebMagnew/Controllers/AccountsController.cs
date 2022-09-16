using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebMagnew.Areas.Admin.Models;
using WebMagnew.Models;
using WebMagnew.ModelView;
using WebMagNews.Helpers;

namespace WebMagnew.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    { 
        private readonly dbBlogsContext _context;
        public INotyfService _notyfService { get; }
        public AccountsController(dbBlogsContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var khachhang = _context.Accounts.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if (khachhang != null)
                    return Json(data: "Số điện thoại : " + Phone + "đã được sử dụng");

                return Json(data: true);

            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = _context.Accounts.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (khachhang != null)
                    return Json(data: "Email : " + Email + " đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [Route("dang-nhap.html", Name = "Login")]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID != null) return RedirectToAction("Index", "Home");
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [Route("dang-nhap.html", Name = "Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Account kh = _context.Accounts
                        .Include(p => p.Role)
                        .SingleOrDefault(p => p.Email.ToLower() == model.Email.ToLower().Trim());
                    if (kh == null)
                    {
                        ViewBag.Error = "Thông tin đăng nhập chưa chính xác";
                        return View(model);
                    }
                    string pass = (model.Password.Trim());
                    if (kh.Password.Trim() != pass)
                    {
                        ViewBag.Error = "Thông tin đăng nhập chưa chính xác";
                        return View(model);
                    }
                    // đăng nhập thành công
                    //ghi nhận thời gian đăng nhập
                    kh.LastLogin = DateTime.Now;
                    _context.Update(kh);
                    await _context.SaveChangesAsync();

                    var taikhoanID = HttpContext.Session.GetString("AccountId");
                    //identity
                    //lưu session makh
                    HttpContext.Session.SetString("AccountId", kh.AccountId.ToString());
                    //identity
                    var userClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, kh.FullName),
                        new Claim(ClaimTypes.Email, kh.Email),
                        new Claim("AccountId",kh.AccountId.ToString()),
                        new Claim("RoleId",kh.RoleId.ToString()),
                        new Claim(ClaimTypes.Role, kh.Role.RoleName)
                    };
                    var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                    await HttpContext.SignInAsync(userPrincipal);

                    if (kh.Role.RoleId == 1 || kh.Role.RoleId == 2)
                    {
                        return RedirectToAction("Index", "Home", routeValues: new { Area = "Admin" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }    
                    
                }
            }
            catch
            {
                return RedirectToAction("Login", "Accounts");
            }
            return RedirectToAction("Login", "Accounts");
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangkyTaiKhoan()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangkyTaiKhoan(RegisterViewModel taikhoan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Account khachhang = new Account
                    {
                        FullName = taikhoan.FullName,
                        Phone = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),
                        Password = taikhoan.Password /*+ salt.Trim()).ToMD5()*/,
                        Active = true,
                        //Salt = salt,
                        RoleId = 1002,
                        CreateDate = DateTime.Now,
                        
                    };
                    try
                    {
                        _context.Add(khachhang);
                        await _context.SaveChangesAsync();
                        //Lưu Session MaKh
                        HttpContext.Session.SetString("AccountId", khachhang.AccountId.ToString());
                        var taikhoanID = HttpContext.Session.GetString("AccountId");

                        //Identity
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,khachhang.FullName),
                            new Claim("AccountId", khachhang.AccountId.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        _notyfService.Success("Đăng ký thành công");
                        return RedirectToAction("Index", "Home");
                    }
                    catch
                    {
                        return RedirectToAction("DangkyTaiKhoan", "Accounts");
                    }
                }
                else
                {
                    return View(taikhoan);
                }
            }
            catch
            {
                return View(taikhoan);
            }
        }
        [Route("edit-profile-user.html", Name = "EditProfileUser")]
        [Authorize, HttpGet]
        public IActionResult EditProfileUser()
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts");
            var account = _context.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taikhoanID));
            if (account == null) return NotFound();
            return View(account);
        }
        [Route("edit-profile-user.html", Name = "EditProfileUser")]
        [Authorize, HttpPost]
        public IActionResult EditProfileUser(Account model)
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts");
            if (ModelState.IsValid)
            {
                var account = _context.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taikhoanID));
                try
                {
                    account.FullName = model.FullName;
                    account.Phone = model.Phone;
                    account.Email = model.Email;
                    _context.Update(account);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                catch
                {
                    return View(model);
                }
            }
            return View();
        }
        [Route("doi-mat-khau-user.html", Name = "ChangePasswordUser")]
        [Authorize, HttpGet]
        public IActionResult ChangePasswordUser()
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts");
            return View();
        }
        [Route("doi-mat-khau-user.html", Name = "ChangePasswordUser")]
        [AllowAnonymous]
        [Authorize, HttpPost]
        public IActionResult ChangePasswordUser(ChangePasswordUserViewModel model)
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts");
            if (ModelState.IsValid)
            {
                var account = _context.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taikhoanID));
                if (account == null) return RedirectToAction("Login", "Accounts");
                try
                {
                    //kiểm tra mật khẩu hiện tại có đúng hay không
                    string passnow = (model.PasswordNow);
                    if (passnow == account.Password.Trim())
                    {
                        account.Password = (model.Password);
                        _context.Update(account);
                        _context.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View();
                    }

                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        //public ActionResult Comment()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Comment(FormCollection collection)
        //{
        //    var mess = collection["message"];
        //    // comment, createdDate, userId, productId
        //    Comment review = new Comment();
        //    review.Contents = mess;
        //    review.CreatedDate = DateTime.Now;
        //    //review.Account = int.Parse(Session["userId"].ToString());
        //    HttpContext.Session.SetString("AccountId", review.AccountId.ToString());
        //    var taikhoanID = HttpContext.Session.GetString("AccountId");
        //    var url = Session["returnPath"].ToString();
        //    var proId = url.Split('/');
        //    review.PostId = int.Parse(proId[proId.Length - 1]);
        //    _context.Comments.Add(review);
        //    _context.SaveChanges();

        //    return Redirect(Session["returnPath"].ToString());
        //}
    }

}

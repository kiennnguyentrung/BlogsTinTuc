﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMagnew.Areas.Admin.Models
{
    public class ChangePasswordViewModel
    {
        [Key]
        public int AccountId { get; set; }
        [Display(Name ="Mật khẩu hiện tại")]
        public string PasswordNow { get; set; }

        [Display(Name ="Mật khẩu mới")]
        [Required(ErrorMessage ="Vui lòng nhập mật khẩu")]
        [MinLength(5, ErrorMessage ="Mật khẩu cần tối thiểu 5 ký tự")]
        
        public string Password { get; set; }
        [MinLength(5, ErrorMessage = "Mật khẩu cần tối thiểu 5 ký tự")]
        [Display(Name = "Nhập lại mật khẩu mới")]
        [Compare("Password",ErrorMessage ="Mật khẩu không giống nhau")]
        public string ConfirmPassord { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tours.WebUI.ViewModels
{
    public class SecurityLoginViewModel
    {
        [Required, Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [Required,Display(Name = "رمز عبور")]
        public string Password { get; set; }
    }
}
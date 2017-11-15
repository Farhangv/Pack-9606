using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class UsersController : Controller
    {
        
        public ActionResult Register()
        {
            return View();
        }

        //public ActionResult RegisterProcessor(FormCollection form)
        //public ActionResult RegisterProcessor(string username, 
        //    string password,
        //    int age)
        [HttpPost]
        public ActionResult Register(User user)
        {
            //var username = Request.Form["username"];
            //var password = Request.Form["password"];
            //var username = form["username"];
            //var password = form["password"];

            //عملیات ثبت نام
            TempData["Message"] = $"{user.Username} عزیز ثبت نام شما با موفقیت انجام شد، لطفا ایمیل خود را چک کنید";
            TempData["Message"] += "<br/>";
            TempData["Message"] += $"سن شما {user.Age} سال است";
            //ارسال به صفحه پیام نهایی
            return RedirectToAction("RegisterFinalMessage");
        }

        public ActionResult RegisterFinalMessage()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            User kiarash = new User()
            {
                Name = "کیارش",
                Family = "کیارشی",
                Location = "کرمانشاه",
                FavoriteFood = "کچلیک",
                EyeColor = "کرم",
                ProgrammingLanguages = new List<string>()
                {
                    "C#","Java", "VB", "JavaScript", "Python", "Perl"
                }
            };
            return View(kiarash);
        }
    }
}
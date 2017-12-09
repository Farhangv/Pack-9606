using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tours.Models;
using Tours.Models.Library;
using Tours.WebUI.Library;
using Tours.WebUI.ViewModels;

namespace Tours.WebUI.Controllers
{
    public class SecurityController : Controller
    {
        protected ToursDb ctx { get; set; } = new ToursDb();
        public ActionResult Login()
        {
            if (SecurityHelper.GetCurrentEmployee() != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Login(string username, string password)
        public ActionResult Login(SecurityLoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var passwordHash = UserHelper.CalculateMD5Hash(viewModel.Password);
                var currentUser = 
                    ctx.Employees.Where(e => e.Username == viewModel.Username
                    && e.PasswordHash == passwordHash)
                    .FirstOrDefault();

                if (currentUser != null)//Authenticated
                {
                    if (viewModel.RememberMe)
                    {
                        //Generate Cookie
                        HttpCookie cookie = 
                            new HttpCookie("UserId", currentUser.Id.ToString());

                        cookie.Expires = DateTime.Now.AddDays(14); // DateTime.Parse("2017/12/25"); 
                        Response.Cookies.Add(cookie);

                    }

                    Session["UserId"] = currentUser.Id;
                    TempData["Message"] = $"{currentUser.Name} {currentUser.Family} ، شما با موفقیت وارد شدید";
                    return RedirectToAction("Index", "Home");
                }
                TempData["Message"] = "نام کاربری یا کلمه عبور شما اشتباه است";
                return View();
            }
            TempData["Message"] = "اطلاعات کاربری به درستی وارد نشده";
            return View();
        }

        public ActionResult Logout()
        {
            SecurityHelper.Logout();
            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
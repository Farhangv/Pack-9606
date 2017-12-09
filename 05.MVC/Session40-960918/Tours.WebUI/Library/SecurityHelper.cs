using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tours.Models;

namespace Tours.WebUI.Library
{
    public static class SecurityHelper
    {
        public static Employee GetCurrentEmployee()
        {
            if (HttpContext.Current.Request.Cookies["UserId"] != null)
            {
                var userId = Convert.ToInt32(HttpContext.Current.Request.Cookies["UserId"].Value);
                HttpContext.Current.Session["UserId"] = userId;
            }

            if (HttpContext.Current.Session["UserId"] != null)
            {
                var userId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
                ToursDb ctx = new ToursDb();
                var currentEmployee = ctx.Employees.Find(userId);
                return currentEmployee;
            }
            else
            {
                return null;
            }
        }

        public static void Logout()
        {
            HttpContext.Current.Session["UserId"] = null;
            var cookie = HttpContext.Current.Request.Cookies["UserId"];
            if(cookie != null)
            {
                //HttpContext.Current.Request.Cookies.Remove("UserId");
                cookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Set(cookie);
            }
        }
    }
}
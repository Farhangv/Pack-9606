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
    }
}
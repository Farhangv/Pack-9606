using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tours.WebUI.Library
{
    public class AuthorizeEmployeeAttribute:ActionFilterAttribute
    {
        //private string role;
        //public AuthorizeEmployeeAttribute(string _role)
        //{
        //    role = _role;
        //}
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (SecurityHelper.GetCurrentEmployee() == null)// Not Authenticated
            {
                //filterContext.Result = new HttpStatusCodeResult(401);
                filterContext.Controller.TempData["Message"] = "شما برای دسترسی به این صفحه باید وارد سایت شوید";
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary()
                {
                    { "action", "Login" } ,
                    { "controller", "Security" }
                }
                    );
                return;
            }

            //if (role != SecurityHelper.GetCurrentEmployee().Role)
            //{
            //    filterContext.Result = new HttpStatusCodeResult(401);
            //    return;
            //}

        }
    }
}
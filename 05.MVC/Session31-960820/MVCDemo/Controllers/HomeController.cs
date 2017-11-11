using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return Content("Hello MVC");
            return new ContentResult() {
                Content = "Hello From Content Object",
                ContentEncoding = Encoding.UTF8,
                ContentType = "text/html"
            };
        }

        public ActionResult About()
        {
            ViewData["CurrentDate"] = DateTime.Now.ToLongDateString();
            return View();
        }
    }
}
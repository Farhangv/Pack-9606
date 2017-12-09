using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tours.Models;
using Tours.WebUI.Library;

namespace Tours.WebUI.Controllers
{
    [AuthorizeEmployee]
    public class PassengersController : Controller
    {
        protected ToursDb ctx { get; set; } = new ToursDb();
        public ActionResult Index()
        {
            var passengers = ctx.Passengers.ToList();
            return View(passengers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Passenger model)
        {
            if (ModelState.IsValid)
            {
                ctx.Passengers.Add(model);
                ctx.SaveChanges();
                TempData["Message"] = "مسافر با موفقیت افزوده شد";
                return RedirectToAction("Index");
            }
            //model.Family = null;
            TempData["Message"] = "فرم ورودی حاوی خطاهای اعتبار سنجی است";
            return View(model);
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
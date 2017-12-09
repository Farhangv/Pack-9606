using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tours.Models;
using Tours.WebUI.Library;
using Tours.WebUI.ViewModels;

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
        public ActionResult Create(PassengersCreateViewModel model)
        {
            var guid = Guid.NewGuid().ToString();
            var postedFile = model.PhotoFile;
            var fileSize = postedFile.ContentLength;
            var fileType = postedFile.ContentType;
            var fileName = //postedFile.FileName;
                guid + Path.GetExtension(postedFile.FileName);
            //postedFile.SaveAs
            if (fileSize > 150 * 1024)
            {
                ModelState.AddModelError(nameof(model.PhotoFile), "سایز فایل نباید از ۱۵۰ کیلو بایت بیشتر باشد");
            }
            if (fileType != "image/gif" && fileType != "image/jpeg" && fileType != "image/png")
            {
                ModelState.AddModelError(nameof(model.PhotoFile), "فایل ارسالی باید عکس باشد");
            }


            if (ModelState.IsValid)
            {
                //ctx.Passengers.Add(model);
                postedFile.SaveAs(Path.Combine(
                    Server.MapPath("~/Photos/") , 
                    fileName));
                var passenger = new Passenger()
                {
                    Name = model.Name,
                    Family = model.Family,
                    NationalCode = model.NationalCode,
                    PassportNumber = model.PassportNumber,
                    PhotoPath = "/Photos/" + fileName
                };
                ctx.Passengers.Add(passenger);
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
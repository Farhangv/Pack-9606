using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tours.Models;
using Tours.WebUI.Library;
using Tours.WebUI.ViewModels;

namespace Tours.WebUI.Controllers
{
    [AuthorizeEmployee]
    public class TourPackagesController : Controller
    {
        private ToursDb ctx = new ToursDb();

        // GET: TourPackages
        public ActionResult Index()
        {
            return View(ctx.TourPackages.ToList());
        }

        // GET: TourPackages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourPackage tourPackage = ctx.TourPackages.Find(id);
            if (tourPackage == null)
            {
                return HttpNotFound();
            }
            return View(tourPackage);
        }

        // GET: TourPackages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TourPackages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description")] TourPackage tourPackage)
        {
            if (ModelState.IsValid)
            {
                ctx.TourPackages.Add(tourPackage);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tourPackage);
        }

        // GET: TourPackages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourPackage tourPackage = ctx.TourPackages.Find(id);
            if (tourPackage == null)
            {
                return HttpNotFound();
            }
            return View(tourPackage);
        }

        // POST: TourPackages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description")] TourPackage tourPackage)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(tourPackage).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tourPackage);
        }

        // GET: TourPackages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourPackage tourPackage = ctx.TourPackages.Find(id);
            if (tourPackage == null)
            {
                return HttpNotFound();
            }
            return View(tourPackage);
        }

        // POST: TourPackages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TourPackage tourPackage = ctx.TourPackages.Find(id);
            ctx.TourPackages.Remove(tourPackage);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ManageAttachments(int tourId)
        {
            var tour = ctx.TourPackages.Find(tourId);
            ViewBag.TourId = tourId;
            ViewBag.TourTitle = tour.Title;
            return View(tour.Attachments.ToList());
        }

        public ActionResult CreateAttachment(int tourId)
        {
            ViewBag.TourId = tourId;
            return View();
        }

        [HttpPost]
        public ActionResult CreateAttachment(int tourId, HttpPostedFileBase attachment)
        {
            var fileName = attachment.FileName;
            var extention = Path.GetExtension(fileName).ToLower();
            var fileSize = (attachment.ContentLength / 1024);
            if (fileSize > 1024)
            {
                ModelState.AddModelError("Attachment", "فایل ارسالی بزرگتر از سایز مجاز است(۱مگابایت)");
            }
            if (extention == ".exe")
            {
                ModelState.AddModelError("Attachment", "فایل اجرایی غیر مجاز است");
            }

            if (ModelState.IsValid)
            {
                Attachment att = new Attachment()
                {
                    OriginalFileName = fileName,
                    FileSize = fileSize,
                    MimeType = attachment.ContentType,
                    TourPackageId = tourId 
                };
                //Convert Stream to Byte[]
                using (var inputStream = attachment.InputStream)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    inputStream.CopyTo(memoryStream);
                    att.FileData = memoryStream.ToArray();
                }

                ctx.Attachments.Add(att);
                ctx.SaveChanges();
                return RedirectToAction("ManageAttachments", new { tourId = tourId });
            }
            return View();
        }

        public ActionResult DownloadAttachment(int id)
        {
            var attachment = ctx.Attachments.Find(id);

            
            return File(attachment.FileData, attachment.MimeType, 
                attachment.OriginalFileName);
            //return File("~/Photos/MVC.docx", "application/octet-stream");
        }

        public ActionResult ManagePassengers(int tourId)
        {
            ViewBag.PassengerId = new SelectList(ctx.Passengers
                .OrderBy(p => p.Family)
                , "Id", "Family");

            TourPackagesManagePassengerViewModel viewModel =
                new TourPackagesManagePassengerViewModel() {
                    Passengers = ctx.TourPackages.Find(tourId).Passengers.ToList()
                };
            return View(viewModel);
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

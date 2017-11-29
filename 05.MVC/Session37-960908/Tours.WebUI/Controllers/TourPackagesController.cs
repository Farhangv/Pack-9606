using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tours.Models;

namespace Tours.WebUI.Controllers
{
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tours.Models;
using Tours.WebUI.Library;

namespace Tours.WebUI.Controllers
{
    public class EmployeesController : Controller
    {
        protected ToursDb ctx { get; set; } = new ToursDb();

        [AuthorizeEmployee]
        public ActionResult Index()
        {
            var employees = ctx.Employees.ToList();
            return View(employees);
        }
        //[AuthorizeEmployee("admin")]
        [AuthorizeEmployee]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost,AuthorizeEmployee]
        public ActionResult Create(Employee employee)
        {
            //ToursDb ctx = new ToursDb();
            ctx.Employees.Add(employee);
            ctx.SaveChanges();
            //return View();
            TempData["Message"] = "کارمند مورد نظر با موفقیت افزوده شد";
            return RedirectToAction("Index");
        }
        [AuthorizeEmployee]
        public ActionResult Edit(int id)
        {
            //ToursDb ctx = new ToursDb();
            var employee = ctx.Employees.Find(id);
            return View(employee);
        }

        [HttpPost,AuthorizeEmployee]
        public ActionResult Edit(Employee employee)
        {
            ctx.Entry<Employee>(employee).State = System.Data.Entity.EntityState.Modified;
            if (string.IsNullOrEmpty(employee.PasswordHash))
                ctx.Entry<Employee>(employee).Property(nameof(employee.PasswordHash)).IsModified = false;

            ctx.SaveChanges();

            TempData["Message"] = "کارمند مورد نظر با موفقیت ویرایش شد";
            return RedirectToAction("Index");
        }
        [AuthorizeEmployee]
        public ActionResult Delete(int id)
        {
            //ToursDb ctx = new ToursDb();
            return View(ctx.Employees.Find(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        [AuthorizeEmployee]
        public ActionResult DeleteConfirmed(int id)
        {
            //ToursDb ctx = new ToursDb();
            ctx.Employees.Remove(ctx.Employees.Find(id));
            ctx.SaveChanges();
            TempData["Message"] = "کارمند مورد نظر با موفقیت حذف شد";
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
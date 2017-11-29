using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tours.Models;

namespace Tours.WebUI.Controllers
{
    public class EmployeesController : Controller
    {
        protected ToursDb ctx { get; set; } = new ToursDb();


        public ActionResult Index()
        {
            //ToursDb ctx = new ToursDb();
            var employees = ctx.Employees.ToList();
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            //ToursDb ctx = new ToursDb();
            ctx.Employees.Add(employee);
            ctx.SaveChanges();
            //return View();
            TempData["Message"] = "کارمند مورد نظر با موفقیت افزوده شد";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            //ToursDb ctx = new ToursDb();
            var employee = ctx.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            //ToursDb ctx = new ToursDb();
            //Method1
            //var dbEmployee = ctx.Employees.Find(employee.Id);
            //dbEmployee.Name = employee.Name;
            //dbEmployee.Family = employee.Family;
            //dbEmployee.Username = employee.Username;
            //if (!string.IsNullOrEmpty(employee.PasswordHash))
            //    dbEmployee.PasswordHash = employee.PasswordHash;

            //Method2
            //ctx.Employees.Attach(employee);
            ctx.Entry<Employee>(employee).State = System.Data.Entity.EntityState.Modified;
            if (string.IsNullOrEmpty(employee.PasswordHash))
                //ctx.Entry<Employee>(employee).Property("PasswordHash").IsModified = false;
                ctx.Entry<Employee>(employee).Property(nameof(employee.PasswordHash)).IsModified = false;

            ctx.SaveChanges();

            TempData["Message"] = "کارمند مورد نظر با موفقیت ویرایش شد";
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            //ToursDb ctx = new ToursDb();
            return View(ctx.Employees.Find(id));
        }

        [HttpPost]
        [ActionName("Delete")]
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
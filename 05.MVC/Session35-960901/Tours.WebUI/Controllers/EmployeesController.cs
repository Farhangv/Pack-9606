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
        public ActionResult Index()
        {
            ToursDb ctx = new ToursDb();
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
            ToursDb ctx = new ToursDb();
            ctx.Employees.Add(employee);
            ctx.SaveChanges();
            //return View();
            TempData["Message"] = "کارمند مورد نظر با موفقیت افزوده شد";
            return RedirectToAction("Index");
        }
    }
}
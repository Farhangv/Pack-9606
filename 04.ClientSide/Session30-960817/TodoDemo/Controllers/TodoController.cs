using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using TodoDemo.Models;

namespace TodoDemo.Controllers
{
    public class TodoController : Controller
    {
        public ActionResult GetTodoList()
        {
            TodoEntities ctx = new TodoEntities();
            Thread.Sleep(1500);
            return Json(ctx.Todoes.ToList(), 
                JsonRequestBehavior.AllowGet);
            
        }
        [HttpPost]
        public ActionResult Insert(Todo model)
        {
            TodoEntities ctx = new TodoEntities();
            ctx.Todoes.Add(model);
            ctx.SaveChanges();
            return Content("رکورد با موفقیت افزوده شد");
        }
    }
}
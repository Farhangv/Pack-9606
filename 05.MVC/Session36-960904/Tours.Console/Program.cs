using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours.Models;

namespace Tours.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ToursDb ctx = new ToursDb();

            //R
            //var people = ctx.People.ToList();
            //var employees = from e in ctx.Employees
            //                where e.Name.StartsWith("P")
            //                select new { Name = e.Name, Family = e.Family };

            //employees.ToList();

            //var employees = ctx.Employees
            //    .Where(e => e.Name.StartsWith("P"))
            //    .Select(e => new { Name = e.Name, Family = e.Family });

            //var employees = ctx.Employees
            //    .Where(e => e.Name.StartsWith("P"))
            //    .OrderByDescending(e => e.Family)
            //    .Select(e => new { Name = e.Name, Family = e.Family });


            //foreach (var item in employees)
            //{
            //    System.Console.WriteLine(item);
            //}

            //Update
            //var employee = ctx.Employees.Where(e => e.Id == 5).FirstOrDefault();
            //employee.Name = "New Name";
            //employee.Family = "New Family";
            //ctx.SaveChanges();

            //ctx.Employees.Remove(ctx.Employees.Where(e => e.Id == 5).FirstOrDefault());
            var people = ctx.People.Where(e => e.Name.StartsWith("P")).ToList();
            //foreach (var p in people)
            //{
            //    ctx.People.Remove(p);
            //}

            ctx.People.RemoveRange(people);
            ctx.SaveChanges();

            System.Console.ReadKey();
        }
    }
}

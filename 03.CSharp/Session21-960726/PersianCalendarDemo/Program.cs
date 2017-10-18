using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PersianCalendarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersianCalendar pc = new PersianCalendar();
            //Console.WriteLine("Enter gregorian birthdate:");
            //DateTime dt = DateTime.Parse(Console.ReadLine());
            //var year = pc.GetYear(dt);
            //var month = pc.GetMonth(dt);
            //var day = pc.GetDayOfMonth(dt);


            //Console.WriteLine($"{year:0000}/{month:00}/{day:00} - {pc.GetDayOfWeek(dt)}");

            var persianBirthDate = Console.ReadLine();
            var dateParts = persianBirthDate.Split('/');
            var persianYear = int.Parse(dateParts[0]);
            var persianMonth = int.Parse(dateParts[1]);
            var persianDay = int.Parse(dateParts[2]);
            var gregorianDate = pc.ToDateTime(persianYear, persianMonth, persianDay, 0, 0, 0, 0);
            Console.WriteLine(gregorianDate.ToShortDateString().Replace('-','/'));
            //Console.WriteLine(gregorianDate.ToString("yyyy/MM/dd"));
            Console.ReadKey();
        }
    }
}

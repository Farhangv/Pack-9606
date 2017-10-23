using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "Lenovo Yoga";
            //p.ProductType = ProductType.Laptop;
            p.ProductType = (ProductType)100;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            

            Console.WriteLine(p.Name);
            Console.WriteLine(p.ProductType);
            Console.WriteLine((int)p.ProductType);

            Console.ReadKey();
        }
    }
}

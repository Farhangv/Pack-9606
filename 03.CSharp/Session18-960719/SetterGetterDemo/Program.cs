using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterGetterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.name = "John Doe";
            p.SetName("John Doe");
            //p.cellPhone = "5236985";
            p.SetCellPhone("091234567890");
            Console.WriteLine($"{p.GetName()}\t{p.GetCellPhone()}");

            Console.ReadKey();
        }
    }
}

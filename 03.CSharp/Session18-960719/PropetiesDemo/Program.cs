using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropetiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.CellPhone = "09123456789";
            Console.WriteLine(p.CellPhone);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 10;
            while (num < 10)
            {
                Console.WriteLine($"While {num}");
            }
            do
            {
                Console.WriteLine($"Do...While {num}");
            } while (num < 10);

            Console.ReadKey();
        }
    }
}

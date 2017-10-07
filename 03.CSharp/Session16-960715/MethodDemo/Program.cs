using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            WriteHello(username);
            //var result = Console.WriteLine(123);

            Console.ReadKey();
        }

        static void WriteHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}

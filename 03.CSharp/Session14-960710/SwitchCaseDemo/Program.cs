using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Programming Language Name: ");
            string language = Console.ReadLine();
            switch (language.ToLower())
            {
                case "c#":
                    Console.WriteLine("Microsoft's OO Language!");
                    break;
                case "java":
                    Console.WriteLine("Cross Platform OO Language!");
                    break;
                case "vb":
                case "vbscript":
                    Console.WriteLine("!!!");
                    break;
                case "javascript":
                    Console.WriteLine("loosley typed language");
                    break;
                default:
                    Console.WriteLine("unkown programming language");
                    break;
            }

            Console.ReadKey();
        }
    }
}

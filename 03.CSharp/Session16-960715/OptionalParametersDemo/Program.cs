using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHello("Sarah Doe", "Mrs");
            WriteHello("John Doe");
            WriteHello("David Smith", persianBirthDate: "1396/07/15");
            Console.ReadKey();
        }
        static void WriteHello(string name, string title = "Mr", string persianBirthDate = "")
        {
            Console.WriteLine($"Hello {title}.{name} , {persianBirthDate}");
        }
    }
}

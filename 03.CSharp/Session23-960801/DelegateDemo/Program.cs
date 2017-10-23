using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void ConsoleTextWriter(string _text);
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleTextWriter ctw = new ConsoleTextWriter(WriteHello);
            ctw += WriteHowAreYou;
            ctw += WriteGoodbye;
            ctw("John");
            ctw("David");

            Console.ReadKey();
        }

        static void WriteHello(string _name)
        {
            Console.WriteLine($"Hello {_name}");
        }

        static void WriteHowAreYou(string _name)
        {
            Console.WriteLine($"How Are You {_name}");
        }

        static void WriteGoodbye(string _name)
        {
            Console.WriteLine($"Goodbye {_name}");
        }
    }
    
}

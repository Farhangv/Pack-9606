using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.Abs(-10);
            Math.Abs(-20);
            //var p = new Program();
            //p.WriteHello();
            WriteHello();
        }

        static void WriteHello()
        {
            Console.WriteLine("");
        }
    }
}

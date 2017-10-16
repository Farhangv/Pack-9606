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
            //Math m = new Math();
            //Console c = new Console();
            //var p = new Program();
            //p.WriteHello();
            WriteHello();

            Samand s = new Samand();
            s.SerialNumber = "3215456456";
            Samand.Company = "Iran Khodro";
        }

        static void WriteHello()
        {
            Console.WriteLine("");
        }
    }
}

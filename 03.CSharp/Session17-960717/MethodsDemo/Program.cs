using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()//Object Initializer
            {
                name = "John",
                family = "Doe"
            };
            //p.name = "John";
            //p.family = "Doe";
            p.Walk();
            p.WriteMyName();

            Person p2 = new Person();
            p2.name = "Sarah";
            p2.family = "Smith";
            p2.Walk();
            p2.WriteMyName();

            Console.ReadKey();
        }
    }
}

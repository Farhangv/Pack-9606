using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Person
    {
        public string name;
        public string family;

        public void Walk()
        {
            Console.WriteLine("I'm walking!");
        }
        public void WriteMyName()
        {
            Console.WriteLine($"My name is {this.name} {this.family}");
        }
    }
}

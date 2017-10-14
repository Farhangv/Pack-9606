using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    class MyClass
    {
        public static int Count { get; set; }

        public MyClass()
        {
            MyClass.Count++;
        }

        ~MyClass()
        {
            MyClass.Count--;
        }

    }
}

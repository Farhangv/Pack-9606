using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingDemo
{
    class Child:Parent
    {
        public new void WriteText()
        {
            Console.WriteLine("Text From Child");
        }
    }
}

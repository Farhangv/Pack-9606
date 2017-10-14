using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.WriteText();//Child
            Parent p = new Child();
            p.WriteText();//Parent
            Console.ReadKey();
        }
    }
}

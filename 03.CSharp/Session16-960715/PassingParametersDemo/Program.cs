using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);
            ChangeInt(ref x);
            Console.WriteLine(x);
            Console.WriteLine("-----------------");
            string t = "Sample";
            Console.WriteLine(t);
            ChangeString(ref t);
            Console.WriteLine(t);
            Console.WriteLine("-----------------");
            int[] a = new int[] { 10 };
            Console.WriteLine(a[0]);
            ChangeArray(ref a);
            Console.WriteLine(a[0]);
            Console.WriteLine("------------------");
            Console.ReadKey();
        }

        static void ChangeInt(ref int num)
        {
            num += 10;
        }

        static void ChangeString(ref string text)
        {
            text += " Changed From Function";
        }

        static void ChangeArray(ref int[] array)
        {
            array[0] += 10;
        }
    }
}

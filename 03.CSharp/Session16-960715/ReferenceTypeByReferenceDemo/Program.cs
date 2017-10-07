using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeByReferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 10 };
            Console.WriteLine(a[0]);
            ChangeArray(ref a);
            Console.WriteLine(a[0]);

            Console.ReadKey();
        }

        static void ChangeArray(ref int[] array)
        {
            //array[0] += 10;
            array = new int[] { 50 };
        }
    }
}

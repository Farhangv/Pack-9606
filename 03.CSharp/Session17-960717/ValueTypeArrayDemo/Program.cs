using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}

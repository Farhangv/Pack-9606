using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int sum = 0;
            for (int number = int.Parse(Console.ReadLine()); number >= 0; number--)
            {
                sum += number;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

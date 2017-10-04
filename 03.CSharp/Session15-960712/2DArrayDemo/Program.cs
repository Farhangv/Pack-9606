using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numner of years:");
            //var count = int.Parse(Console.ReadLine());
            var sales = new int[int.Parse(Console.ReadLine()), 12];
            for (int i = 0; i <= sales.GetUpperBound(0); i++)
            {
                Console.WriteLine($"Please Enter Sales For Year {i + 1}");
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine($"Month {j + 1}:");
                    sales[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i <= sales.GetUpperBound(0); i++)
            {
                var sum = 0.0;
                for (int j = 0; j < 12; j++)
                {
                    sum += sales[i, j];
                }
                Console.WriteLine($"Year {i + 1} Average Sales: {sum / 12.0:#,###.00}");
            }

            Console.ReadKey();
        }
    }
}

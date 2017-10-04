using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            Console.WriteLine($"Enter {numbers.Length} Numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            //Console.WriteLine(Convert.ToDouble(sum) / Convert.ToDouble(5));
            Console.WriteLine(sum / Convert.ToDouble(numbers.Length));
            Console.ReadKey();
        }
    }
}

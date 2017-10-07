using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo2
{
    class Program
    {
        static void Main()
        {
            //var nums = new int[] { 1, 8, 9, 6, 52, 41, 78, 96, 32, 52, 47 };
            //var result = Sum(nums);
            //var result = Sum(new int[] { 1, 8, 9, 6, 52, 41, 78, 96, 32, 52, 47 });
            var result = Sum(1, 8, 9, 6, 52, 41, 78, 96, 32, 52, 47);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Sum(params int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}

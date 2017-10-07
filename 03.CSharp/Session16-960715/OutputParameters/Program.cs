using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 8, 9, 6, 52, 41, 78, 96, 32, 52, 47 };
            double avg;// = 0; //unassigned
            int min;// = 0;
            int max;// = 0;
            var sum = Sum(nums, out avg, out min, out max);

            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Average : {avg}");
            Console.WriteLine($"Min : {min}");
            Console.WriteLine($"Max : {max}");

            Console.ReadKey();
        }

        static int Sum(int[] numbers, out double average,
            out int min, out int max)
        {
            var sum = 0;
            min = numbers[0];
            max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (min > numbers[i])
                    min = numbers[i];
                if (max < numbers[i])
                    max = numbers[i];

            }
            average = sum / numbers.Length;
            return sum;
        }
    }
}

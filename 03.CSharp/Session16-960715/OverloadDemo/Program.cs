using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(1, 2);
            Sum(new double[] { 10.3, 6.7, 15.9 });
            //Console.WriteLine()
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

        static double Sum(double[] numbers)
        {
            var sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

    }
}

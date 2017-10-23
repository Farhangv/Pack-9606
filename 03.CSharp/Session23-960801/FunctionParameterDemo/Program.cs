using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameterDemo
{
    public delegate bool NumberFilter(int _number);
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //WriteFilteredNumbers(numbers, EvenFilter);
            //WriteFilteredNumbers(numbers, 
            //    (x) 
            //    => 
            //    {
            //        return x % 2 == 0;
            //    });

            WriteFilteredNumbers(numbers, x => x % 2 == 0);
            Console.ReadKey();

        }

        static void WriteFilteredNumbers(int[] _numbers, NumberFilter _filter)
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if(_filter(_numbers[i]))
                    Console.WriteLine(_numbers[i]);
            }
        }

        static bool OddFilter(int _number)
        {
            return _number % 2 != 0;
        }
        static bool EvenFilter(int _number)
        {
            return _number % 2 == 0;
        }
        static bool PrimeFilter(int _number)
        {
            if (_number == 1)
                return true;

            for (int i = 2; i < _number; i++)
            {
                if (_number % i == 0)
                    return false; 
            }
            return true;
        }
    }
}

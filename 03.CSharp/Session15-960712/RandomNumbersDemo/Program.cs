using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();//ابزار تولید اعداد تصادفی
            //Console.WriteLine(r.Next(1, 200));
            int[] randomNumbers = new int[100];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next(1, 200);
            }

            Array.Sort(randomNumbers);
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}

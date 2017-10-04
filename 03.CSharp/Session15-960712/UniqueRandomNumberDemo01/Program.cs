using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UniqueRandomNumberDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var min = 1;
            var max = 2000000;
            var randomNumbers = new int[500000];

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < randomNumbers.Length;)
            {
                var newRandomNumber = r.Next(min, max);
                bool isUnique = true;
                for (int j = 0; j < i; j++)//جستجو به دنبال عدد تکراری
                {
                    if (randomNumbers[j] == newRandomNumber)//عدد تکراری داریم
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)//اگر عدد یکتا بود
                {
                    randomNumbers[i++] = newRandomNumber;
                    //i++;
                }
            }
            sw.Stop();
            Array.Sort(randomNumbers);
            foreach (var number in randomNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("------------------");
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UniqueRandomNumberDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var min = 1;
            var max = 2000000;
            var randomNumbers = new int[500000];
            var domain = new int[max - min + 1];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < domain.Length; i++)
            {
                domain[i] = min++;
            }
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                var randomIndex = r.Next(0, domain.Length - i);
                randomNumbers[i] = domain[randomIndex];
                domain[randomIndex] = domain[domain.Length - 1 - i];
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

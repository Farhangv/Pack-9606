using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculatable[] calculatables = new ICalculatable[]
                {
                    new Employee() { Name = "John", Family = "Doe", Balance = -100000 },
                    new Student() { Name = "Sarah", Family = "Smith", Balance = 200000 },
                    new Product() { Balance = -50000 },
                    new Service() { Balance = -150000 }
                };

            var sum = 0;
            foreach (ICalculatable calculatable in calculatables)
            {
                Console.WriteLine(calculatable.Balance);
                
                sum += calculatable.Balance;
            }

            Console.WriteLine("------------------");
            Console.WriteLine(sum);

            Console.ReadKey();

            
        }
    }
}

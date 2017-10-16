using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
                {
                    new Person() { Name = "John", Family = "Doe" },
                    new Person() { Name = "Ali", Family = "Alian" },
                    new Person() { Name = "Sara", Family = "Sarayi" },
                    new Person() { Name = "David", Family = "Doe" }
                };

            Array.Sort(people);

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}

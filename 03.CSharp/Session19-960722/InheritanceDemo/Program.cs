using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            Person[] people = new Person[]
                {
                    new Student() { Name = "John" , Family = "Doe", NationalCode = "1234567890", UnitCount = 14, PricePerUnit = 120000 },
                    new Student() { Name = "David" , Family = "Doe", NationalCode = "1237537890", UnitCount = 24, PricePerUnit = 120000 },
                    new Student() { Name = "Sarah" , Family = "Smith", NationalCode = "1234562546", UnitCount = 16, PricePerUnit = 100000 },
                    new Teacher() { Name = "Ross" , Family = "Geller", NationalCode = "5214569875", CostPerHour = 100000, TeachingHours = 40 },
                    new Teacher() { Name = "Monica", Family = "Geller", NationalCode = "4569871235", CostPerHour = 120000, TeachingHours = 25 },
                    new Employee() { Name = "Ali", Family = "Alian", NationalCode = "1234567890", CostPerHour = 50000, WorkingHours = 100 },
                    new SalesEmployee() { Name = "Reza", Family = "Rezayi", NationalCode = "1234567890", CostPerHour = 50000, WorkingHours = 100, Percentage = 10, TotalSales = 1000000 },
                };

            var balance = 0;
            foreach (Person person in people)
            {
                Console.WriteLine(person);
                balance += person.GetBalance();
                //Console.WriteLine($"{person.Name} {person.Family}");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine(balance);
            Console.ReadKey();
        }
    }
}

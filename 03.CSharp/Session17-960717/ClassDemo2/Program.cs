using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // شی پی را از جنس کلاس پرسن ایجاد میکنیم
            Person p = new Person();
            Person john = new Person();
            john.name = "John";
            john.family = "Doe";
            Person sarah = new Person();
            Person[] people = new Person[4];
            people[0] = john;
            people[1] = new Person();
            people[1].name = "Sarah";
            people[1].family = "smith";
            people[2] = new Person();
            people[2].name = "David";
            people[2].family = "Doe";
            people[3] = john;

            john.name = "Johnney";

            //p.name = Console.ReadLine();
            //p.family = Console.ReadLine();

            //Console.WriteLine($"Hello {p.name} {p.family}");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.name} {person.family}");
            }

            Console.ReadKey();
        }
    }
}

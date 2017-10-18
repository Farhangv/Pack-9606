using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("C#"); ;
            names.Add("Java"); ; ; ; ; ; ; ; ;
            names.Add("Python");

            names.Remove("Java");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            List<Person> people = new List<Person>();
            var p1 = new Person()
            {
                Name = "Sarah",
                Family = "Smith"
            };
            people.Add(new Person() { Name = "John", Family = "Doe" });
            people.Add(p1);
            people.Remove(new Person() { Name = "John", Family = "Doe" });

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Family}");
            }
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public override bool Equals(object obj)
        {
            var other = obj as Person;
            if (other != null)
            {
                return this.Name.ToLower() == other.Name.ToLower() &&
                    this.Family.ToLower() == other.Family.ToLower();
            }
            else
                return false;

        }
    }
}

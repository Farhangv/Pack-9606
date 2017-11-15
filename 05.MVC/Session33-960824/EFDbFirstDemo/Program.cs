using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name\nFamily\nBirth Date\nPhone\nCellPhone");
            PhoneBookEntities context = new PhoneBookEntities();
            context.People.Add(
                new Person()
                {
                    Name = Console.ReadLine(),
                    Family = Console.ReadLine(),
                    BirthDate = DateTime.Parse(Console.ReadLine()),
                    Contacts = new List<Contact>()
                    {
                        new Contact() { Type = "PHN", Value = Console.ReadLine() },
                        new Contact() { Type = "CLL", Value = Console.ReadLine() }
                    }
                }
                );

            context.SaveChanges();
        }
    }
}

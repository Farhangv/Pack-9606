using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours.Models;

namespace Tours.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Retrieve Update Delete
            //Create Context Object
            ToursDb ctx = new ToursDb();

            //Employee e = new Employee()
            //{
            //    Name = "John",
            //    Family = "Doe",
            //    Username = "JohnD",
            //    PasswordHash = "123"
            //};
            //e.Contacts = new List<Contact>();
            //e.Contacts.Add(
            //    new Contact()
            //{
            //    ContactType = ContactType.CellPhone,
            //    Value = "091234567890"
            //});
            //e.Contacts.Add(
            //    new Contact()
            //{
            //        ContactType = ContactType.HomePhone,
            //        Value = "02112345678"
            //});

            //ctx.Employees.Add(e);
            //ctx.SaveChanges();

            //Passenger p = new Passenger()
            //{
            //    Name = "David",
            //    Family = "Smith",
            //    BirthDate = DateTime.Now.AddYears(-30),
            //    PassportNumber = "E12345678"
            //};
            //ctx.Passengers.Add(p);
            //ctx.SaveChanges();

            //Retrieve
            //var passengers = ctx.Passengers.ToList();

            //foreach (Passenger passenger in passengers)
            //{
            //    System.Console.WriteLine($"{passenger.Name} {passenger.Family} {passenger.PassportNumber}");
            //}

            //var firstPassenger = ctx.Passengers.First();
            //System.Console.WriteLine($"{firstPassenger.Name}");

            var firstTour = ctx.TourPackages.FirstOrDefault();
            System.Console.WriteLine($"{firstTour.Title}");

            System.Console.ReadKey();
        }
    }
}

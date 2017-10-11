using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Laptop".GetHashCode());
            //Console.WriteLine(123.GetHashCode());
            Person p = new Person()
            {
                Name = "John",
                Family = "Doe",
                BirthDate = DateTime.Parse("1980/10/10"),
                NationalCode = "123456789"
            };
            Person p2 = new Person()
            {
                Name = "John",
                Family = "Doe",
                BirthDate = DateTime.Parse("1980/10/10"),
                NationalCode = "1234567890"

            };

            Random r = new Random();
            DateTime dt = new DateTime();
            Int32 i = new Int32();

            Console.WriteLine(p.GetType());
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p.Equals(p2));

            object o = new Person();
            object o1 = 10;
            object o2 = "Salaam";
            object o3 = DateTime.Now;
            Console.WriteLine(p.Equals(o1));
            
            Console.ReadKey();
        }
    }
}

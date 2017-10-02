using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "John";
            //string family = "Doe";
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Family:");
            string family = Console.ReadLine();
            Console.WriteLine("Please Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth Date?");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            
                  
            Console.WriteLine(
                $"{name} {family}\nYour Age Is {DateTime.Now.Year - birthDate.Year}");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username?");
            string username = Console.ReadLine().ToLower();
            Console.WriteLine("Password?");
            string password = Console.ReadLine();
            //"Sample"
            //    .Equals("sample", 
            //    StringComparison.InvariantCultureIgnoreCase);

            if (username == "admin" && password == "admin")
            //{
                Console.WriteLine("Welcome Admin");
            //}
            else if (username == "user" && password == "pass")
            //{
                Console.WriteLine("Welcome User");
            //}
            else
            //{
                Console.WriteLine("Invalid Username Or Password!");
            //}
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
                {//Array Initializer
                    "C#",//0
                    "Java",//1
                    "PHP",//2
                    "Python",
                    "Perl",
                    "JavaScript"
                };

            //string[][] families = new string[][]
            //    {
            //        new string[] { "Doe", "sajkdhkjasd" },
            //        new string[] { "Doe", "sajkdhkjasd" },
            //        new string[] { "Doe", "sajkdhkjasd" },
            //    };
            //names[0] = "C#";
            //names[1] = "Java";
            foreach (string name in names)
            {
                //name = "New Name";
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}

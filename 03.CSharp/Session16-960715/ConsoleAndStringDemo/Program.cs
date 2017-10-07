using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAndStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Doe";
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(name[2]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name.Substring(2, 3));


            Console.Clear();
            Console.WriteLine(" |\n |\n |\n |");
            while (true)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {

                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

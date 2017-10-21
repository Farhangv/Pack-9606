using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCursorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Salaam");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 5);
            Console.CursorVisible = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(10, 5 + i);
            }


            Console.ReadKey();
        }
    }
}

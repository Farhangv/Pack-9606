using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number:");
                var input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
                //var number = int.Parse(Console.ReadLine());
                var number = int.Parse(input);
                var result = 1;
                //var name = Console.ReadLine();
                //var name;
                while (number > 1)
                    //{
                    //result = result * number;
                    //result *= number;
                    //number = number - 1;
                    //number -= 1;
                    //number--;
                    //--number;

                    result *= number--;
                //1. علمبات دیگر
                //2.عملیات تفریق 

                //result *= --number;
                //1. علمبات تفریق
                //2.عملیات دیگر 

                //}
                Console.WriteLine(result);
                Console.WriteLine("-----------------");
            }
            Console.ReadKey();
        }
    }
}

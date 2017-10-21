using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pattern:");
                var pattern = Console.ReadLine();
                if (pattern.ToLower() == "exit")
                    break;
                Regex re = new Regex(pattern);
                while (true)
                {
                    Console.Write("Text:");
                    var text = Console.ReadLine();
                    if (text.ToLower() == "exit")
                        break;

                    var result = re.IsMatch(text);
                    if (result)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"{text} : {pattern}");

                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }
        }
    }
}

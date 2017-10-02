using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string family = "Doe";
            string date = "1396/07/10";
            string account = "123-564-456789-2";
            int balance = 1000000;
            //Console.WriteLine("Hello " + name + " " + family + 
            //    "\nDate: " + date + "\n" + "Your Account: " + 
            //    account + "\n" + "Balance: " + balance);
            //Console.WriteLine("Hello {0} {1}\nDate: {2}\nAccount: {3}\nBalance: {4}, Goodbye",
            //    name,family, date, account, balance);
            Console.WriteLine($"Hello {name} {family}\nDate: {date}\nAccount: {account}\nBalance: {balance:#,###}");
            Console.ReadKey();
        }
    }
}

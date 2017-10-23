using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            while (true)
            {
                Product p = new Product();
                p.InvalidQuantityEneterd += new InvalidQuantityEnteredHandler(p_invalidQuantity);
                Console.Write("Name: ");
                p.Name = Console.ReadLine();
                Console.WriteLine("Quantity: ");
                p.Quantity = int.Parse(Console.ReadLine());
                
            }
        }

        static void p_invalidQuantity(int _invalidQuantity)
        {
            Console.WriteLine("Invalid Quantity Enetered");
        }
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1234, "John Doe");
            ht.Add(3424, "David Doe");
            ht.Add(7658, "Sarah Smith");
            ht.Add(3426, "Ali Alian");
            ht.Add("CEO", "Payam Payami");
            ht.Add("CTO", new Person() { Name = "Maryam", Family = "Maryami" });

            //ht.Add(1234, "Reza Rezayi");
            //Console.WriteLine(ht[1234]);
            //Console.WriteLine(ht["CEO"]);

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"[{item.Key}]: {item.Value}");
            }

            Console.ReadKey();

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Java", "PHP", "Python" };
            ArrayList al = new ArrayList();
            al.Add("C#");
            al.Add(123);
            al.Add(new Person() { Name = "John", Family = "Doe" });
            al.Add(123);
            al.Add(DateTime.Now);
            al.Add(new Person() { Name = "Sarah", Family = "Smith" });
            al.AddRange(names);

            //al.Clear();
            Console.WriteLine($"ArrayList Count: {al.Count}");
            Console.WriteLine("------------------");

            al.Remove("C#");
            al.Remove(123);
            al.Remove(new Person() { Name = "John", Family = "Doe" });
            al.RemoveAt(0);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"Index Of 123: {al.IndexOf(123)}");
            //Console.WriteLine($"{al[1]}");
            Console.WriteLine($"Last Index Of 123: {al.LastIndexOf(123)}");
            Console.WriteLine($"Index Of David: {al.IndexOf("David")}");

            Console.WriteLine($"Index Of John Doe {al.IndexOf(new Person() { Name = "John", Family = "Doe" })}");
            Console.WriteLine($"Contains John Doe {al.Contains(new Person() { Name = "John", Family = "Doe" })}");

            Console.WriteLine($"ArrayList Count: {al.Count}");

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public override string ToString()
        {
            return $"{Name} {Family}";
        }
        public override bool Equals(object obj)
        {

            var other = obj as Person;
            if (other != null)
            {
                return this.Name.ToLower() == other.Name.ToLower() &&
                    this.Family.ToLower() == other.Family.ToLower();
            }
            else
                return false;
        }
    }
}

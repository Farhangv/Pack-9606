using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Course csharpCourse = new Course()
            {
                Title = "Introduction To C#",
                Students = new Student[] {
                    new Student() { Name = "John", Family = "Doe" },
                    new Student() { Name = "Ali", Family = "Alian" },
                    new Student() { Name = "Sara", Family = "Sarayi" },
                    new Student() { Name = "David", Family = "Doe" }
                }
            };


            foreach (Student student in csharpCourse)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}

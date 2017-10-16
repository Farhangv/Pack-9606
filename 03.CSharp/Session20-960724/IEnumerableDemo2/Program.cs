using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var csharpExam = new Exam()
            {
                Title = "C# Final Exam",
                Questions = new Question[]
                {
                    new Question() { Id = 1, Text = "What is variable?" },
                    new Question() { Id = 2, Text = "What is value type?" },
                    new Question() { Id = 3, Text = "What is reference type?" },
                    new Question() { Id = 4, Text = "What is method?" },
                    new Question() { Id = 5, Text = "What is overriding?" },
                    new Question() { Id = 6, Text = "What is hiding?" }
                }
            };

            foreach (Question question in csharpExam)
            {
                Console.WriteLine(question);
            }

            Console.ReadKey();
        }
    }
}

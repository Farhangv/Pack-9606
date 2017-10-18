using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> q = new Queue<int>();
            Stack<int> s = new Stack<int>();
            //q.Enqueue(200);
            //q.Enqueue(201);
            //q.Enqueue(202);

            var startNumber = 200;

            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        //q.Enqueue(startNumber++);
                        s.Push(startNumber++);
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        //WriteNumbersInQueue(q);
                        //if(q.Count != 0)
                            //Console.WriteLine(q.Dequeue());
                        if(s.Count != 0)
                            Console.WriteLine(s.Pop());
                        else
                            //Console.WriteLine("No Customers in queue");
                            Console.WriteLine("Nobody in stack");
                        break;
                }
            }

        }


        static void WriteNumbersInQueue(Queue<int> q)
        {
            while (q.Count != 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            Console.ReadKey();
        }
    }
}

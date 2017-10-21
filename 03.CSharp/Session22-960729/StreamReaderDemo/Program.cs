using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StreamReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"D:\Sample.txt"))
            {
                //while (sr.Peek() != -1)
                //{
                //    //Console.Write((char)sr.Read());
                //    Console.WriteLine(sr.ReadLine());
                //}
                //Console.WriteLine(sr.ReadToEnd());
                sr.ReadLine();
                char[] buffer = new char[20];
                sr.ReadBlock(buffer,0,20);
                for (int i = 0; i < buffer.Length; i++)
                {
                    Console.Write(buffer[i]);
                }
            }

            Console.ReadKey();
        }
    }
}

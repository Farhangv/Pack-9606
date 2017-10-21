using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //0.
            //var file = File.Create(@"File.txt");
            //var sw = new StreamWriter(file);
            //1.
            //StreamWriter sw = File.CreateText(@"D:\Sample.txt");

            //2.
            using (StreamWriter sw = new StreamWriter(@"D:\Sample.txt", true))
            {
                sw.AutoFlush = true;
                while (true)
                {
                    var input = Console.ReadLine();
                    if (input.ToLower() == "exit")
                        break;

                    sw.WriteLine(input);
                    //sw.Flush();
                }
            }//sw.Close();


            Console.ReadKey();
        }
    }
}

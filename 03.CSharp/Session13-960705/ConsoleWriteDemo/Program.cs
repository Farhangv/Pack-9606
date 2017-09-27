using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriteDemo
{
    class Program
    {
        static void Main()
        {
            //Single Line Comment
            /*
             * Multi
             * Line
             * Comment
             */
            //WriteMyName();

            Console.WriteLine(100);
            Console.Write("Hello C#");
            Console.WriteLine();
            

            Console.ReadKey();
        }

        /// <summary>
        /// این تابع نام شما را در کنسول مینویسد
        /// </summary>
        /// <param name="name">نام شما</param>
        static void WriteMyName(string name)
        {

        }
    }
}

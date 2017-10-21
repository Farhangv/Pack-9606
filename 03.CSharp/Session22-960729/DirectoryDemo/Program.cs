using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo di = new DirectoryInfo("");
            //var newDirectory = Directory.CreateDirectory(@"D:\New Directory From C#");
            //newDirectory.CreateSubdirectory(DateTime.Now.ToShortDateString());
            //Console.WriteLine(Directory.Exists(@"D:\New Directory From C#"));
            Directory.Delete(@"D:\New Directory From C#", true);

            Console.ReadKey();
        }
    }
}

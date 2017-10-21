using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            var content = wc.DownloadString("http://www.tabnak.ir/");
            using (StreamWriter sw = new StreamWriter("Tabnak.txt", false, Encoding.UTF8))
            {
                sw.WriteLine(content);
            }

        }
    }
}

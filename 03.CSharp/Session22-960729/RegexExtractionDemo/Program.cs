using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExtractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            var content = wc.DownloadString("http://www.tabnak.ir");
            Regex re = new Regex("href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))");
            var matches = re.Matches(content);
            using (StreamWriter sw = new StreamWriter("Links.txt", false, Encoding.UTF8))
            {
                foreach (Match match in matches)
                {
                    sw.WriteLine(match.Groups[1]);
                    Console.WriteLine(match.Groups[1]);
                }
            }

            Console.ReadKey();
        }
    }
}

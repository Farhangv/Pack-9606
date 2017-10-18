using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(123456, "John Doe");

            foreach (KeyValuePair<int, string> item in employees)
            {
                
            }
        }
    }
}

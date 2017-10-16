using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Student
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Family}";
        }
    }
}

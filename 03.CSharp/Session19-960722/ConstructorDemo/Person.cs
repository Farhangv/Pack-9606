using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Person
    {
        public Person(string _name, string _family)
        {
            Name = _name;
            Family = _family;
        }
        public string Name { get; set; }
        public string Family { get; set; }

        ~Person()
        {
            
        }
    }
}

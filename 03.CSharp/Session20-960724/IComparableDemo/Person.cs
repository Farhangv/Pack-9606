using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Person:IComparable
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Family}";
        }

        public virtual int CompareTo(object obj)
        {
            //return this.Family.CompareTo(((Person)obj).Family);
            var other = obj as Person;
            //return this.Family.CompareTo(other.Family);
            var result = this.Family.CompareTo(other.Family);
            if (result == 0)
                result = this.Name.CompareTo(other.Name);

            return result;
        }
    }
}

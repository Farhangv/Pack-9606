using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourMethodsDemo
{
    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalCode { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Family}, National Code: {this.NationalCode}";
        }
        public override int GetHashCode()
        {
            //return int.Parse(this.NationalCode);
            string fullName = Name.ToLower() + Family.ToLower();
            return fullName.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                //Person other = (Person)obj;
                Person other = obj as Person;
                //return this.GetHashCode() == obj.GetHashCode();
                return this.NationalCode == other.NationalCode;
            }
            return false;
        }
    }
}

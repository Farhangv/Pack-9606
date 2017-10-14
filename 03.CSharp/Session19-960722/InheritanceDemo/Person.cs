using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        //public virtual int GetBalance()
        //{
        //    return 0;
        //}
        public abstract int GetBalance();
        public override string ToString()
        {
            return $"{this.Name}\t{this.Family}: {this.GetBalance()}";
        }
    }
}

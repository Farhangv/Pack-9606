using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Student:Person
    {
        public int UnitCount { get; set; }
        public int PricePerUnit { get; set; }

        public override int GetBalance()
        {
            return (UnitCount * PricePerUnit);
        }
    }
}

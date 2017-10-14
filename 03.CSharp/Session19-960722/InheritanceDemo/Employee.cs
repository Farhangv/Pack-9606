using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee:Person
    {
        public int WorkingHours { get; set; }
        public int CostPerHour { get; set; }
        public override int GetBalance()
        {
            return -1 * WorkingHours * CostPerHour;
        }
    }
}

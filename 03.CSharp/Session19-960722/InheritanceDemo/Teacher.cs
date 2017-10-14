using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Teacher:Person
    {
        public int TeachingHours { get; set; }
        public int CostPerHour { get; set; }
        public override int GetBalance()
        {
            return this.TeachingHours * this.CostPerHour * -1;
        }
        public override string ToString()
        {
            return $"TEACHER: {this.Name}\t{this.Family}: {this.GetBalance()}";
        }
    }
}

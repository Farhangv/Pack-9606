using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SalesEmployee:Employee
    {
        public int TotalSales { get; set; }
        public int Percentage { get; set; }

        public override int GetBalance()
        {
            //return (-1 * WorkingHours * CostPerHour) -
            //            ((Percentage * TotalSales) / 100);
            return base.GetBalance()  -
                ((Percentage * TotalSales) / 100);

        }
    }
}

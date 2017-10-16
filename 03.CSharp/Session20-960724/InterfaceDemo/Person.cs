using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Person : ICalculatable
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Balance
        {
            get;

            set;
        }

        public virtual int GetBalance()
        {
            return Balance;
        }
    }
}

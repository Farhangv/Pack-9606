using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Product : ICalculatable
    {
        public int Balance
        {
            get;

            set;
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}

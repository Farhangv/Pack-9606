using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface ICalculatable
    {
        int Balance { get; set; }
        int GetBalance();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Product
    {
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
    }

    public enum ProductType
    {
        Laptop = 100,
        Monitor = 200,
        PC = 300,
        Mouse
    }
}

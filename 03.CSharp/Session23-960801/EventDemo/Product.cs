using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public delegate void InvalidQuantityEnteredHandler(int _invalidQuantity);

    class Product
    {
        public string Name { get; set; }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set {

                if (value > 0)
                    quantity = value;
                else
                    InvalidQuantityEneterd(value);
            }
        }


        public event InvalidQuantityEnteredHandler InvalidQuantityEneterd;
    }
}

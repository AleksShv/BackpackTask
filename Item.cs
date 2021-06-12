using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackTask
{
    public class Item
    {
        public double Weight { get; private init; }
        public double Price { get; private init; }

        public Item(double weight, double price)
        {
            Weight = weight;
            Price = price;
        }
    }
}

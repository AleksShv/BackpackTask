using System;
using System.Collections.Generic;
using System.Linq;


namespace BackpackTask
{
    public class Backpack
    {
        public double CapacityWeight { get; private init; }
        public double CurrentWeight => _items.Sum(item => item.Weight);

        private List<Item> _items;

        public Backpack(double capacityWeight)
        {
            CapacityWeight = capacityWeight;
            _items = new List<Item>();
        }

        public List<Item> ViewItems()
        {
            return _items;
        }

        public void AddItem(Item item)
        {
            if (CurrentWeight + item.Weight > CapacityWeight)
                throw new Exception("Backpack overflow");

            _items.Add(item);
        }
    }
}

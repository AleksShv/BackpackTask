using System;
using System.Collections.Generic;
using System.Linq;


namespace BackpackTask
{
    public class Backpack
    {
        public List<Item> Items { get; }
        public int Capacity { get; private init; }
        public int FreeSpace => Capacity - Items.Sum(item => item.Weight);
        public int ItemsPrice => Items.Sum(item => item.Price);

        public Backpack(int capacity)
        {
            Capacity = capacity;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (item.Weight > FreeSpace)
                throw new Exception("Backpack overflow");

            Items.Add(item);
        }

        public void AddItems(IEnumerable<Item> items)
        {
            if (items.Sum(item => item.Weight) > FreeSpace)
                throw new Exception("Backpack overflow");

            Items.AddRange(items);
        }
    }
}

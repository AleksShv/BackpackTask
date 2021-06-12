using System;
using System.Collections.Generic;
using System.Linq;


namespace BackpackTask
{
    public static class Task
    {
        public static void Put(this Backpack backpack, List<Item> items)
        {
            var itemsWeight = items.Sum(item => item.Weight);
            var itemsPrice = items.Sum(item => item.Price);
            

        }


    }
}

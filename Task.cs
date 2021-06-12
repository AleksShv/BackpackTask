using System;
using System.Collections.Generic;
using System.Linq;


namespace BackpackTask
{
    public static class Task
    {
        public static void Put(this Backpack backpack, List<Item> items)
        {
            Backpack[,] bp = new Backpack[items.Count + 1, backpack.Capacity + 1];

            for (int i = 0; i < items.Count + 1; i++)
            {
                for (int j = 0; j < backpack.Capacity + 1; j++)
                {
                    bp[i, j] = new Backpack(backpack.Capacity);

                    if (i == 0 || j == 0)
                    {
                        bp[i, j].AddItem(Item.Empty);
                    }
                    else if (i == 1)
                    {
                        if (items[0].Weight <= j)
                        {
                            bp[i, j].AddItem(items[0]);
                        }
                        else
                        {
                            bp[i, j].AddItem(Item.Empty);
                        }
                    }
                    else
                    {
                        if (items[i - 1].Weight > j)
                        {
                            bp[i, j] = bp[i - 1, j]; 
                        }
                        else
                        {
                            var temp = new Backpack(backpack.Capacity);
                            temp.AddItem(items[i - 1]);
                            temp.AddItems(bp[i - 1, j - items[i - 1].Weight].Items);

                            if (bp[i - 1, j].ItemsPrice > temp.ItemsPrice)
                            {
                                bp[i, j] = bp[i - 1, j];
                            }
                            else
                            {
                                bp[i, j] = temp;
                            }
                        }
                    }
                }
            }

            backpack.AddItems(bp[items.Count, backpack.Capacity].Items);
        }
    }
}

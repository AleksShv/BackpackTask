using BackpackTask;
using System;
using System.Collections.Generic;

List<Item> items = new List<Item>()
{
    new Item(6, 5),
    new Item(4, 3),
    new Item(3, 1),
    new Item(2, 3),
    new Item(5, 6),
};

Backpack backpack = new Backpack(15);

backpack.Put(items);

foreach (var item in backpack.Items)
{
    Console.WriteLine($"Weight: {item.Weight}, Price: {item.Price}");
}

Console.WriteLine($"Best price: {backpack.ItemsPrice}, weight: {backpack.Capacity - backpack.FreeSpace}/{backpack.Capacity}");

using BackpackTask;
using System;
using System.Collections.Generic;

List<Item> items = new List<Item>()
{
    new Item(1, 1),
    new Item(1, 1),
    new Item(1, 1),
    new Item(1, 1),
    new Item(1, 1),
    new Item(1, 1),
    new Item(1, 1),
    new Item(1, 1),
    new Item(1, 1)
};

Backpack backpack = new Backpack(10);

backpack.Put(items);



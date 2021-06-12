namespace BackpackTask
{
    public class Item
    {
        public int Weight { get; private init; }
        public int Price { get; private init; }

        public static Item Empty => new Item(0, 0);

        public Item(int weight, int price)
        {
            Weight = weight;
            Price = price;
        }
    }
}

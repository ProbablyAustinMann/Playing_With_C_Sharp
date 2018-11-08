using System;
namespace RPGInventory.Item
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }

    }
}

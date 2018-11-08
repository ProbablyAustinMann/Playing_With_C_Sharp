using System;
namespace RPGInventory.Item.Armor
{
    public class WoodenShield : Item
    {
        public WoodenShield()
        {
            Name = "A Wooden Shield";
            Description = "More likely to break than protect you";
            Weight = 3;
            Type = "Armor";
        }
    }
}

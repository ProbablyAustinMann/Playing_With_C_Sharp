using System;
namespace RPGInventory.Item.Potions
{
    public class HealthPotion : Item
    {
        public HealthPotion()
        {
            Name = "A Health Potion";
            Description = "Red fizzy liquid";
            Weight = 1;
            Type = "Potion";
        }
    }
}

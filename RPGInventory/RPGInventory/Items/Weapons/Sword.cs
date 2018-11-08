using System;
namespace RPGInventory.Item.Weapons
{
    public class Sword : Item
    {
        public Sword()
        {
            Name = "A Wooden Sword";
            Description = "It's dangerous to go alone, take this with you.";
            Weight = 3;
            Type = "Weapon";
        }
    }
}

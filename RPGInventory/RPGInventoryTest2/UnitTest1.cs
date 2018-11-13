using System;
using NUnit.Framework;
using RPGInventory.Item.Containers;
using RPGInventory.Item.Potions;
using RPGInventory.Item;
using RPGInventory.Item.Weapons;
namespace RPGInventoryTest
{
    [TestFixture]
    public class ContainerTest
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            bool actual = b.AddItem(p);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            Backpack b = new Backpack();
            GreatAxe axe = new GreatAxe();

            b.AddItem(axe);
            b.AddItem(axe);
            b.AddItem(axe);
            b.AddItem(axe);

            bool actual = b.AddItem(axe);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);

            Item actual = b.RemoveItem();

            Assert.AreEqual(p, actual);
        }

        [Test]
        public void EmptyBagReturnsNull() 
        {
            Backpack b = new Backpack();
            Item item = b.RemoveItem();
            Assert.IsNull(item);
        }

        [Test]
        public void PotionSachelOnlyAllowsPotions()
        {
            PotionSachel sachel = new PotionSachel();
            GreatAxe axe = new GreatAxe();

            bool result = sachel.AddItem(axe);
            Assert.IsFalse(result);

            HealthPotion potion = new HealthPotion();
            result = sachel.AddItem(potion);
            Assert.IsTrue(result);
        }
    }
}

using System;
using NUnit.Framework;
using RPGInventory.Items.Containers;
using RPGInventory.Items.Potions;

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
    }
}

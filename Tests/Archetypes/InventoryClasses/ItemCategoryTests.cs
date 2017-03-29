
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.InventoryClasses;

namespace Open.Tests.Archetypes.InventoryClasses
{
    /// <summary>
    /// Summary description for ItemCategoryTests
    /// </summary>
    [TestClass]
    public class ItemCategoryTests : ClassTests<ItemCategory>
    {
        
        [TestMethod]
        public void IsEnum() { Assert.IsTrue(typeof(InventoryStatus).IsEnum); }
        [TestMethod]
        public void CountTest() { Assert.AreEqual(8, GetEnum.Count<ItemCategory>()); }
        [TestMethod]
        public void ComputerTest() { Assert.AreEqual(0, (int)ItemCategory.Computer); }
        [TestMethod]
        public void PhoneTest() { Assert.AreEqual(1, (int)ItemCategory.Phone); }
        [TestMethod]
        public void AudioTest() { Assert.AreEqual(2, (int)ItemCategory.Audio); }
        [TestMethod]
        public void HomeAppliancesTest() { Assert.AreEqual(3, (int)ItemCategory.HomeAppliances); }
        [TestMethod]
        public void KitchenAppliancesTest() { Assert.AreEqual(4, (int)ItemCategory.KitchenAppliances); }
        [TestMethod]
        public void HomeCinemaTest() { Assert.AreEqual(5, (int)ItemCategory.HomeCinema); }
        [TestMethod]
        public void PhotoVideoTest() { Assert.AreEqual(6, (int)ItemCategory.PhotoVideo); }
        [TestMethod]
        public void GamesTest() { Assert.AreEqual(7, (int)ItemCategory.Games); }
    }
}


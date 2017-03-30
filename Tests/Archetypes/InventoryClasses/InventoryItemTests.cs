using Open.Archetypes.BaseClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.InventoryClasses;

namespace Open.Tests.Archetypes.InventoryClasses
{
    [TestClass]
    public class InventoryItemTests : ClassTests<InventoryItem>
    {
        private InventoryItem e;
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new InventoryItem().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
        [TestInitialize]
        public void Init()
        {
            e = new InventoryItem();
        }
    }
}

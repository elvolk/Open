using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.InventoryClasses;

namespace Open.Tests.Archetypes.InventoryClasses
{
    [TestClass] public partial class InventoryEntryTests : ClassTests<Inventory>
    {
        private InventoryEntry e;
        [TestMethod] public void ConstructorTest()
        {
            var a = new InventoryEntry().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }

        [TestInitialize] public void Init()
        {
            e = new InventoryEntry();
        }

        [TestMethod] public void ConstructorTest1()
        {
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void NumberAvailableTest()
        {
           //IntPropertyTest(() => e.NumberAvailable, x => e.NumberAvailable = x);
        }
        
    }
}

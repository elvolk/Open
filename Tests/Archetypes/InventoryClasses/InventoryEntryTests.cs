using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.InventoryClasses;

namespace Open.Tests.Archetypes.InventoryClasses
{
    [TestClass] public class InventoryEntryTests : CommonTests<InventoryEntry>
    {
        protected override InventoryEntry GetRandomObj()
        {
            return InventoryEntry.Random();
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            ProductInstances.Instance.AddRange(ProductInstances.Random());
        }
        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
            ProductInstances.Instance.Clear();
        }
        
        [TestMethod] public void ConstructorTest()
        {
            var a = new InventoryEntry().GetType().BaseType;
            Assert.AreEqual(a, typeof(UniqueEntity));
        }

        [TestMethod]
        public void NumberAvailableTest()
        {
            TestProperty(() => Obj.NumberReserved, x => Obj.NumberReserved = x);
        }

        [TestMethod]
        public void AddProductInstanceTest()
        {
            var a = ProductInstance.Random();
            var c = ProductInstances.Instance.Count;
            Obj.AddProductInstance(a);
            Assert.AreEqual(c+1, ProductInstances.Instance.Count); 
            Assert.AreEqual(a, ProductInstances.Instance.Find(x => x.UniqueId == a.UniqueId));
        }
        
    }
}

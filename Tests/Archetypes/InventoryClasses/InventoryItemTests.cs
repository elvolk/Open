using Open.Archetypes.BaseClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.InventoryClasses;

namespace Open.Tests.Archetypes.InventoryClasses
{
    [TestClass]
    public class InventoryItemTests : CommonTests<InventoryItem>
    {
        protected override InventoryItem GetRandomObj()
        {
            return InventoryItem.Random();
        }
        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
            Entities.Instance.Clear();
        }
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new InventoryItem().GetType().BaseType;
            Assert.AreEqual(a, typeof(BaseList<InventoryEntry>));
        }

        [TestMethod] public void ItemNameTest()
        {
            Obj = new InventoryItem();
            TestProperty(() => Obj.ItemName, x => Obj.ItemName = x);
        }

        [TestMethod]
        public void DescriptionTest()
        {
            Obj = new InventoryItem();
            TestProperty(() => Obj.Description, x => Obj.Description = x);
        }

        [TestMethod]
        public void ProductTypeIdTest()
        {
            Obj = new InventoryItem();
            TestProperty(() => Obj.ProductTypeId, x => Obj.ProductTypeId = x);
        }
        [TestMethod]
        public void ItemTest()
        {
            Assert.IsNull(Obj.Item);
            var e = Entity.Random();
            e.UniqueId = Obj.ItemName;
            Entities.Instance.Add(e);
            Assert.AreEqual(e, Obj.Item);
        }
    }
}

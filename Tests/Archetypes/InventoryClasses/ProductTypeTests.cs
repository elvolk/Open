using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.InventoryClasses;

namespace Open.Tests.Archetypes.InventoryClasses
{
    [TestClass]
    public class ProductTypeTests: CommonTests<ProductType>
    {
        protected override ProductType GetRandomObj() { return ProductType.Random(); }
        
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
        }
        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new ProductType().GetType().BaseType;
            Assert.AreEqual(a, typeof(BaseType<ProductType>));
        }

        [TestMethod]
        public void NameTest()
        {
            Obj = new ProductType();
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }

        [TestMethod]
        public void DescriptionTest()
        {
            Obj = new ProductType();
            TestProperty(() => Obj.Description, x => Obj.Description = x);
        }
        [TestMethod]
        public void TypeTest()
        {
            Assert.IsNull(Obj.Type);
            var t = ProductType.Random();
            t.UniqueId = Obj.TypeId;
            //ProductTypes.Instance.AddRange(ProductTypes.Random());
            ProductTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.Type);
        }
    }
}

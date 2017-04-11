﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.InventoryClasses;
namespace Open.Tests.Archetypes.InventoryClasses
{
    [TestClass]
    public class InventoryTests : CommonTests<Inventory>
    {
        protected override Inventory GetRandomObj()
        {
            return Inventory.Random();
        }
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Inventory().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}
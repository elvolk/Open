using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.InventoryClasses;

namespace Open.Tests.Archetypes.InventoryClasses
{
    
    [TestClass]
    public class InventoryStatusTests : ClassTests<InventoryStatus>
    {
        [TestMethod]
        public void IsEnum() { Assert.IsTrue(typeof(InventoryStatus).IsEnum); }
        [TestMethod]
        public void CountTest() { Assert.AreEqual(4, GetEnum.Count<InventoryStatus>()); }
        [TestMethod]
        public void OtherTest() { Assert.AreEqual(0, (int)InventoryStatus.PastStorage); }
        [TestMethod]
        public void PhoneTest() { Assert.AreEqual(1, (int)InventoryStatus.CurrentInventory); }
        [TestMethod]
        public void MobileTest() { Assert.AreEqual(15, (int)InventoryStatus.Processing); }
        [TestMethod]
        public void FaxTest() { Assert.AreEqual(99, (int)InventoryStatus.Unknown); }
    }
}

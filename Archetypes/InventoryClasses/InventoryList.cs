using System;
using System.Collections.Generic;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryList
    {
        public InventoryList(string ItemName, int quantity, int ItemId, 
            string ItemCategory, int InventoryId, string Description, 
            double InventoryStatus, DateTime ProductValidUntil)
        {
            List<InventoryList> ProductList = new List<InventoryList>();
            var result = ProductList.Find(Product => ItemName == "ItemName");
            
            var capacity = ProductList.Capacity;
            for (var i = 0; i < 10000; i++)
            {
                if (ProductList.Capacity > capacity)
                {
                    capacity = ProductList.Capacity;
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;

namespace Open.Archetypes.InventoryClasses
{
    public class Product
    {
        public Product(string ItemName, int quantity, int ItemId, 
            string ItemCategory, int InventoryId, string Description, 
            double InventoryStatus, DateTime ProductValidUntil)
        {
            List<Product> ProductList = new List<Product>();
            var result = ProductList.Find(Product => ItemName == "ItemName");

            if (ProductList != null)
            {
                ProductList.Add(new Product("ItemName", 10, 1265, "TOOTED1", 667, "Hea toode", 1, new DateTime(2017, 03, 03)));
            }

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

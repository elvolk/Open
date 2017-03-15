using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
   public class ProductType : Archetype
    {
        public static ProductType Instance { get; } = new ProductType();

        internal static ProductType GetProductType(string productTypeId)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
   public class ProductType : Archetype
    {
        public static ProductType Instance { get; } = new ProductType();
        private string name;
        private string description;

        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }

        internal static ProductType GetProductType(string productTypeId)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
   public class ProductType : BaseType<ProductType>
    {
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

        public ProductTypes Inherited(string productTypeId)
        {
            return ProductTypes.GetInherited(UniqueId);
        }

        public override ProductType Type => ProductTypes.GetById(UniqueId);
    }
}

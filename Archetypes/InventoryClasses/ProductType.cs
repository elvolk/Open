using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
   public class ProductType : BaseType<ProductType>
    {
        public static ProductType Instance { get; } = new ProductType();
        private string name;
        private string description;

        public static ProductType Random()
        {
            var t = new ProductType();
            t.SetRandomValues();
            return t;
        }

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

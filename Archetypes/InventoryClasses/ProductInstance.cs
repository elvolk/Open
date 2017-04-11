using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ProductInstance: BaseEntity<ProductType>
    {
        public static ProductInstance Instance { get; } = new ProductInstance();
        public override ProductType Type => ProductTypes.GetById(TypeId);

        public static ProductInstance Random()
        {
            var e = new ProductInstance();
            e.SetRandomValues();
            return e;
        }
    }
}

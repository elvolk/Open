using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ProductInstance: BaseEntity<ProductType>
    {
        public override ProductType Type => ProductTypes.GetById(TypeId);
    }
}

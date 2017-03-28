using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ProductInventoryEntry : Archetype
    {
        private int quantityOnOrder;

        public int QuantityOnOrder
        {
            get { return SetDefault(ref quantityOnOrder); }
            set { SetValue(ref quantityOnOrder, value); }
        }
        
    }
}

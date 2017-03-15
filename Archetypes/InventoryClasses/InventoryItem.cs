using System;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryItem: BaseList<InventoryEntry>
    {
        public static InventoryItem Instance { get; } = new InventoryItem();
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public string ItemCategory { get; set; }
        public int InventoryId { get; set; }
        public string Description { get; set; }
        public double InventoryStatus { get; set; }
        public DateTime ProductValidUntil { get; set; }
        private string productTypeId;
        public string ProductTypeId
        {
            get { return productTypeId; }
            set { SetValue(ref productTypeId, value); }
        }
        public ProductType GetProductType()
        {
            return ProductType.GetProductType(ProductTypeId);
        }
    }
}

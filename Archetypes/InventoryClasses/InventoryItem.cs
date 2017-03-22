using System;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryItem: BaseList<InventoryEntry>
    {
        public static InventoryItem Instance { get; } = new InventoryItem();

        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { SetValue(ref itemName, value); }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { SetValue(ref quantity, value); }
        }

        private int itemId;
        public int ItemId
        {
            get { return itemId; }
            set { SetValue(ref itemId, value); }
        }

        private string itemCategory;
        public string ItemCategory
        {
            get { return itemCategory; }
            set { SetValue(ref itemCategory, value); }
        }

        private int inventoryId;
        public int InventoryId
        {
            get { return inventoryId; }
            set { SetValue(ref inventoryId,value); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { SetValue(ref description, value); }
        }

        private double inventoryStatus;
        public double InventoryStatus
        {
            get { return inventoryStatus; }
            set { SetValue(ref inventoryStatus, value); }
        }

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

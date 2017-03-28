using System;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryItem: BaseList<InventoryEntry>
    {
        public static InventoryItem Instance { get; } = new InventoryItem();
        private string itemName;
        private int quantity;
        private int itemId;
        private ItemCategory itemcategory;
        private int inventoryId;
        private string description;
        private double inventoryStatus;
        private DateTime productValidUntil;
        private string productTypeId;
        public string ItemName
        {
            get { return SetDefault(ref itemName); }
            set { SetValue(ref itemName, value); }
        }

        public int Quantity
        {
            get { return SetDefault(ref quantity); }
            set { SetValue(ref quantity, value); }
        }
        
        public int ItemId
        {
            get { return SetDefault(ref itemId); }
            set { SetValue(ref itemId, value); }
        }
        public ItemCategory itemCategory
        {
            get { return SetDefault(ref itemcategory); }
            set { SetValue(ref itemcategory, value); }
        }

        public int InventoryId {
            get { return SetDefault(ref inventoryId); }
            set { SetValue(ref inventoryId, value); }
        }
        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }
        public double InventoryStatus {
            get { return SetDefault(ref inventoryStatus); }
            set { SetValue(ref inventoryStatus, value); }
        }
        public DateTime ProductValidUntil {
            get { return SetDefault(ref productValidUntil); }
            set { SetValue(ref productValidUntil, value); }
        }
        public string ProductTypeId
        {
            get { return productTypeId; }
            set { SetValue(ref productTypeId, value); }
        }

        public enum ItemCategory
        {
            //TODO: sozdat
        }

        public ProductType GetProductType()
        {
            return ProductType.GetProductType(ProductTypeId);
        }
    }
}

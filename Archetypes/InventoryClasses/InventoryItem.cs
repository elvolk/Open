using System;
using Open.Aids;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryItem: BaseList<InventoryEntry>
    {
        public static InventoryItem Instance { get; } = new InventoryItem();
        private string itemName;
        private int quantity;
        private int itemId;
        private ItemCategory category;
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
        public ItemCategory Category
        {
            get { return SetDefault(ref category); }
            set { SetValue(ref category, value); }
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

        public static InventoryItem Random()
        {
            var x = new InventoryItem();
            x.SetRandomValues();
            return x;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            itemName = GetRandom.String(5, 7);
            itemId = GetRandom.Int32(4, 8);
            quantity = GetRandom.Int32(1, 1000);
            description = GetRandom.String(1); 
        }

        public ProductType GetProductType()
        {
            return ProductType.GetProductType(ProductTypeId);
        }
    }
}

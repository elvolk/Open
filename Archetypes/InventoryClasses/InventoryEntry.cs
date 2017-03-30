using System.Collections.Generic;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryEntry: UniqueEntity
    {
        List<InventoryEntry> inventoryList = new List<InventoryEntry>();
        private string productTypeId;
        private bool canAcceptRequest;
        private int numberReserved;
        public int NumberAvailable
        {
            get { return ProductInstances.GetInstances(ProductTypeId); }
        }
        public int NumberReserved
        {
            get { return SetDefault(ref numberReserved); }
            set { SetValue(ref numberReserved, value); }
        }

        public bool CanAcceptReservationRequest
        {
            get { return SetDefault(ref canAcceptRequest); }
            set { SetValue(ref canAcceptRequest, value); }
        }

        public string ProductTypeId
        {
            get { return SetDefault(ref productTypeId); }
            set { SetValue(ref productTypeId, value); }
        }
        public ProductType ProductType => ProductTypes.GetById(ProductTypeId);

        public void Capacity()
        {
            var capacity = inventoryList.Capacity;
            for (var i = 0; i < 10000; i++)
            {
                if (inventoryList.Capacity > capacity)
                {
                    capacity = inventoryList.Capacity;
                }
            }
        }
        public static InventoryEntry Random()
        {
            var x = new InventoryEntry();
            x.SetRandomValues();
            return x;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            numberReserved = GetRandom.Int32(1, 500);
        }

        public void AddProductInstance()
        {
             
        }

        public void RemoveProductInstance()
        {
            
        }
    } 
}
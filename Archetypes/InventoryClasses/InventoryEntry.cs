using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryEntry: Archetype
    {
        List<InventoryEntry> inventoryList = new List<InventoryEntry>();
        private bool canAcceptRequest;
        private int numberAvailable;
        private int numberReserved;
        private ProductType productType;
        public int NumberAvailable
        {
            get { return SetDefault(ref numberAvailable); }
            set { SetValue(ref numberAvailable, value); }
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

        public ProductType ProductType
        {
            get { return SetDefault(ref productType); }
            set { SetValue(ref productType, value); }
        }
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

        public void AddProductInstance()
        {
            
        }

        public void RemoveProductInstance()
        {
            
        }
    } 
}
using System;
using Open.Archetypes.InventoryClasses;

namespace Open.Logic.InventoryClasses
{
    public class InventoryEntryEditModel : InventoryEntry
    {
        public InventoryEntryEditModel() { }

        public InventoryEntryEditModel(InventoryUsage i)
        {
            var inv = i?.Entry as InventoryEntry;
            var v = i?.Valid as ValidPeriod;
            if (inv == null) return;
            NumberAvailable = i.NumberAvailable;
            NumberReserved = i.NumberReserved;
            CanAcceptReservationRequest = i.CanAcceptReservationRequest;
            ProductType = i.ProductType;
            ValidFrom = v.Valid.From;
            ValidTo = v.Valid.To;
        }
        public string NumberAvailable { get; set; }
        public string NumberReserved { get; set; }
        public string CanAcceptReservationRequest { get; set; }
        public string ProductType { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}


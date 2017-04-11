using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryUsage : UniqueEntity
    {
        private InventoryEntry inventory;

        public string CanAcceptReservationRequest { get; internal set; }

        public InventoryEntry Entry
        {
            get { return SetDefault(ref inventory); }
            set { SetValue(ref inventory, value); }
        }

        public static InventoryUsage Random()
        {
            var i = new InventoryUsage();
            i.SetRandomValues();
            return i;
        }

        public string NumberAvailable { get; internal set; }
        public string NumberReserved { get; internal set; }
        public string ProductType { get; internal set; }
        public new object Valid { get; internal set; }
    }
}

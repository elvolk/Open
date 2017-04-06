
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryEntries: Archetypes<InventoryEntry>
    {
        public static InventoryEntries Instance { get; } = new InventoryEntries();
        //random
    }
}

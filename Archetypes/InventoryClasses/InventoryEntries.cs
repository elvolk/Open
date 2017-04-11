
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class InventoryEntries: Archetypes<InventoryEntry>
    {
        public static InventoryEntries Instance { get; } = new InventoryEntries();
        public static InventoryEntries Random()
        {
            var r = new InventoryEntries();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(InventoryEntry.Random());
            return r;
        }
        public static InventoryEntry Find(string uniqueId) => Instance.Find(x => x.IsThisUniqueId(uniqueId));
    }
}

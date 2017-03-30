using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.InventoryClasses
{
    public class Inventory: Archetypes<InventoryEntry>
    {
        public static Inventory Instance { get; } = new Inventory();

        public static Inventory Random()
        {
            var a = new Inventory();
            var b = GetRandom.Count();
            for(var i = 0; i<b; i++) a.Add(InventoryEntry.Random());
            return a;
        }

        //public static InventoryEntry Find(string uniqueId)
        //{
        //    return Instance.Find(x => x.IsThisUniqueId(uniqueId));
        //}
    }
}

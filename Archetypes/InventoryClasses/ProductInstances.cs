using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ProductInstances : Archetypes<ProductInstance>
    {
        public static ProductInstances Instance { get; } = new ProductInstances();
        public static int GetInstancesCount(string productTypeId)
        {
            return Instance.FindAll(x => x.TypeId == productTypeId).Count;
        }
        public static ProductInstances Random()
        {
            var r = new ProductInstances();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(ProductInstance.Random());
            return r;
        }
    }
}

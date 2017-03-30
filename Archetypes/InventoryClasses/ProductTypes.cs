using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ProductTypes: Archetypes<ProductType>
    {
        public static ProductTypes Instance { get; } = new ProductTypes();
        public static ProductType GetById(string uniqueId)
        {
            return Instance.Find(x=> x.IsThisUniqueId(uniqueId));
        }

        public static ProductTypes GetInherited(string uniqueId)
        {
            var t = new ProductTypes();
            var l = Instance.FindAll(x => x.TypeId == uniqueId);
            t.AddRange(l);
            return t;
        }
    }
}

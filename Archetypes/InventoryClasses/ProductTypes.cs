﻿using Open.Aids;
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
        public static ProductTypes Random()
        {
            var r = new ProductTypes();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(ProductType.Random());
            return r;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ProductInstance: BaseEntity<ProductType>
    {
        public override ProductType Type => ProductTypes.GetById(TypeId);
    }
}

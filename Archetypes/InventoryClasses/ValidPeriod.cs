using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ValidPeriod : TemporalEntity
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

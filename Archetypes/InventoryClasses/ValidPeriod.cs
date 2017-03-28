using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class ValidPeriod : TemporalEntity
    {
        private DateTime fromDateTime;
        private DateTime toDateTime;
        public DateTime From {
            get { return SetDefault(ref fromDateTime); }
            set { SetValue(ref fromDateTime, value); }
        }
        public DateTime To {
            get { return SetDefault(ref toDateTime); }
            set { SetValue(ref toDateTime, value); }
        }
    }
}

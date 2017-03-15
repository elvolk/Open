namespace Open.Archetypes.InventoryClasses
{
   public class InventoryStatus
    {
        public enum ProductStatus
        {
            PastStorage = 0,
            CurrentInventory = 1,
            Processing = 15,
            Unknown = 99 
        }
    }
}

namespace Open.Archetypes.InventoryClasses
{
    public class BaseClass
    {
        public void SetValue<T>(ref T field, T value)
        {
            field = value;
        }
    }
}

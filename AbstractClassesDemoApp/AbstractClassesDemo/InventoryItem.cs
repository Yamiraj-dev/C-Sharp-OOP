namespace AbstractClassesDemo
{
    public abstract class InventoryItem // an abstract class is a base class, it is a base, not complete. just build on top of it
        // you inherit from an abstract class, but you can't instantiate it.
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }    
    }
}
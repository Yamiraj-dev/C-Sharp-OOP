namespace AbstractClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryItem item = new Book(); // cannot directly instantiate InventoryItem as it is an abstract class.

            Car car = new Car();

            item.ProductName = "Test";
            
            Console.ReadLine(); 
        }
    }

    public abstract class Vehicle
    {
        public string VINNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4; // default value is 4, a car typically has 4 wheels

    }
}
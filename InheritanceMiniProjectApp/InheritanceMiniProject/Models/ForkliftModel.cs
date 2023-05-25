using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
    public class ForkliftModel : InventoryItemModel, IRental
    {
        public void Lift()
        {
            Console.WriteLine("I'm lifting.");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine($"This {ProductName} is being rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine($"This {ProductName} has been returned.");
        }
    }
}
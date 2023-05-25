using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
    public class BookModel : InventoryItemModel, IPurchase
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine($"This {ProductName} has been purchased.");
        }
    }
}
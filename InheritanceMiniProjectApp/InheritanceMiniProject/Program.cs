using InheritanceMiniProject.Interfaces;
using InheritanceMiniProject.Models;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rental = new List<IRental>();
            List<IPurchase> purchase = new List<IPurchase>();

            var vehicle = new VehicleModel { DealerFee = 100, ProductName = "Kia Sportage" };
            var book = new BookModel { ProductName = "Sun Tzu's Art of War", NumberOfPages = 400 };
            var forklift = new ForkliftModel { ProductName = "Kobe Forklift", QuantityInStock = 3 };

            rental.Add(vehicle);
            rental.Add(forklift);

            purchase.Add(book);
            purchase.Add(vehicle);

            Console.Write("Do you want to rent or puchase: (rent/purchase)");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rental)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no)");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes/no)");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchase)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this item (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }

                Console.WriteLine("We are done");
            }
            Console.ReadLine();
        }
    }
}
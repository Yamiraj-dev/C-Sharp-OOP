﻿using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
    public class VehicleModel : InventoryItemModel, IPurchase, IRental
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine($"This {ProductName} has been purchased.");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine($"This {ProductName} has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine($"This {ProductName} has been returned.");
        }
    }
}
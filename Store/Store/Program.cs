using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Product, decimal> cart = new Dictionary<Product, decimal>();
            cart.Add(new Food("apples", "BrandA", 1.5m, DateTime.Parse("June 14, 2021")), 2.45m);
            cart.Add(new Food("milk", "BrandM", 0.99m, DateTime.Parse("February 2, 2022")), 3m);
            cart.Add(new Clothe("T-shirt", "BrandT", 15.99m, Clothe.Size.M, "violet"), 2);
            cart.Add(new Appliance("laptop", "BrandL", 2345m, "ModelL", DateTime.Parse("March 3, 2021"), 1.125m), 1);
            Cashier.PrintReceipt(cart);
        }
    }
}

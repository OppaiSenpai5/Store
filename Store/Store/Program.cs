using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Product, decimal> cart = new Dictionary<Product, decimal>();
            cart.Add(new Food("apples", "BrandA", 1.5m, new DateTime(2021, 6, 14)), 2.45m);
            Cashier.PrintReceipt(cart);
        }
    }
}

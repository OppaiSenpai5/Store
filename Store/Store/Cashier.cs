using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cashier
    {
        public static void PrintReceipt(Dictionary<Product, decimal> cart)
        {
            Console.WriteLine($"Date: {DateTime.Now}\n---Products---\n");

            decimal subtotal = 0m;
            decimal discount = 0m;

            foreach (KeyValuePair<Product, decimal> item in cart)
            {
                Product product = item.Key;
                decimal quantity = item.Value;

                decimal totalPrice = product.Price * quantity;
                decimal discountSum = totalPrice * product.Discount;

                Console.WriteLine($"{product.Name} {product.Brand}");
                Console.WriteLine($"{quantity} x {product.Price} = {totalPrice:.00}");
                Console.WriteLine($"#discount {product.Discount:P2} {discountSum:0.00}\n");

                subtotal += totalPrice;
                discount += discountSum;
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"SUBTOTAL: {subtotal}");
            Console.WriteLine($"DISCOUNT: -{discount}");
            Console.WriteLine($"TOTAL: {subtotal - discount}");
        }
    }
}

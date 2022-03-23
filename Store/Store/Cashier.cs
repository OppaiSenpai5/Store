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

            foreach (KeyValuePair<Product, decimal> product in cart)
            {
                decimal totalPrice = product.Key.Price * product.Value;
                decimal discountSum = product.Key.Price * product.Key.Discount;

                Console.WriteLine($"{product.Key.Name} {product.Key.Brand}");
                Console.WriteLine($"{product.Value} x {product.Key.Price} = {totalPrice}");
                Console.WriteLine($"#discount {product.Key.Discount:P2} {discountSum}\n");

                subtotal += totalPrice;
                discount += discountSum;
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"SUBTOTAL: {subtotal}");
            Console.WriteLine($"DISCOUNT: -{discount}");
            Console.WriteLine($"TOTAL: {subtotal - discount}");
        }
    }
}

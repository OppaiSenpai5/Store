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
            Console.WriteLine($"Date: {DateTime.Now}\n---Products---");

            decimal subtotal = 0m;
            decimal discount = 0m;

            foreach (KeyValuePair<Product, decimal> item in cart)
            {
                Product product = item.Key;
                decimal quantity = item.Value;

                decimal totalPrice = product.Price * quantity;
                decimal discountSum = totalPrice * product.Discount;

                Console.WriteLine($"\n{product.Name} {product.Brand}");
                Console.WriteLine($"{quantity} x {product.Price} = {totalPrice:C2}");
                if (discountSum != 0)
                    Console.WriteLine($"#discount {product.Discount:P2} {discountSum:C2}");

                subtotal += totalPrice;
                discount += discountSum;
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"SUBTOTAL: {subtotal:C2}");
            Console.WriteLine($"DISCOUNT: -{discount:C2}");
            Console.WriteLine($"TOTAL: {subtotal - discount:C2}");
        }
    }
}

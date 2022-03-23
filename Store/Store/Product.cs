using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public virtual decimal Discount { get; } = 0m;

        public Product(string name, string brand, decimal price) =>
            (Name, Brand, Price) = (name, brand, price);
    }
}

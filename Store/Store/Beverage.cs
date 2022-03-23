using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Beverage : PerishableProduct
    {
        public Beverage(string name, string brand, decimal price, DateTime expirationDate)
            : base(name, brand, price, expirationDate)
        {
        }
    }
}

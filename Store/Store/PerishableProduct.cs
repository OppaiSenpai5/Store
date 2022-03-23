using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class PerishableProduct : Product
    {
        public DateTime ExpirationDate { get; set; }
        public override decimal Discount
        {
            get
            {
                if (this.ExpirationDate.Day == DateTime.Now.Day)
                    return 0.5m;
                if (this.ExpirationDate.Day - DateTime.Now.Day <= 5)
                    return 0.1m;
                return 0m;
            }
        }

        public PerishableProduct(string name, string brand, decimal price, DateTime expirationDate)
            : base(name, brand, price)
        {
            ExpirationDate = expirationDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Appliance : Product
    {
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Weight { get; set; }
        public override decimal Discount
        {
            get
            {
                if ((DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                    && this.Price > 999m)
                    return 0.05m;
                return 0m;
            }
        }

        public Appliance(string name, string brand, decimal price, string model, DateTime productionDate, int weight)
            : base(name, brand, price)
        {
            Model = model;
            ProductionDate = productionDate;
            Weight = weight;
        }
    }
}

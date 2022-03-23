using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Clothe : Product
    {
        public Size ClotheSize { get; set; }
        public string Color { get; set; }
        public override decimal Discount
        {
            get
            {
                if (DateTime.Now.DayOfWeek > DayOfWeek.Saturday && DateTime.Now.DayOfWeek < DayOfWeek.Saturday)
                    return 0.1m;
                return 0m;
            }
        }

        public Clothe(string name, string brand, decimal price, Size size, string color)
            : base(name, brand, price)
        {
            ClotheSize = size;
            Color = color;
        }

        public enum Size
        {
            XS, S, M, L, XL
        }
    }
}

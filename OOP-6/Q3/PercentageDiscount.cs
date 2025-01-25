using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Q3
{
    internal class PercentageDiscount:Discount
    {
        private decimal percentage;

        public PercentageDiscount(decimal p)
        {
            percentage = p;
            Name = "Percentage Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100);
        }
    }
}

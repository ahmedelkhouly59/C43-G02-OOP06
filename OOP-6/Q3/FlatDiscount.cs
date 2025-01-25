using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Q3
{
    internal class FlatDiscount : Discount
    {
        private decimal fixedAmount;

        public FlatDiscount(decimal fixedamount_)
        {
            fixedAmount = fixedamount_;
            Name = "Flat Discount";
        }


        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return fixedAmount * Math.Min(quantity, 1);
        }
    }
}

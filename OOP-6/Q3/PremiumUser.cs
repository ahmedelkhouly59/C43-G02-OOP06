using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Q3
{
    internal class PremiumUser:User
    {
        public PremiumUser()
        {
            Name = "Premium User";
        }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Q3
{
    internal class RegularUser : User
    {
        public RegularUser()
        {
            Name = "Regular User";
        }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}

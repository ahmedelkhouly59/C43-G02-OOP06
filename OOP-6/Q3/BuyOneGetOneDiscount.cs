﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Q3
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {

            return (price / 2) * (quantity / 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Q3
{
    abstract class Discount
    {
        public abstract decimal CalculateDiscount(decimal price, int quantity);
        public string Name { get; set; }
    }
}

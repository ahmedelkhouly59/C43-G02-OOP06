using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Q3
{
    abstract class User
    {
        public string Name {  get; set; }
        public abstract Discount GetDiscount();
    }



}

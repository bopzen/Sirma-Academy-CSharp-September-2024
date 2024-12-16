using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public class NoDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount;
        }
    }
}

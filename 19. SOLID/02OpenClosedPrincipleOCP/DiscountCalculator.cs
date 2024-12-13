using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public class DiscountCalculator
    {
        private readonly IDiscoundStrategy _discoundStrategy;

        public DiscountCalculator(IDiscoundStrategy discoundStrategy)
        {
            _discoundStrategy = discoundStrategy;
        }

        public double Calculate(double price)
        {
            return _discoundStrategy.CalculateDiscount(price);
        }
    }
}

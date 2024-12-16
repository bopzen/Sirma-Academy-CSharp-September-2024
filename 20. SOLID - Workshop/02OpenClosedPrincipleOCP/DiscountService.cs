using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public class DiscountService
    {
        private IDiscountStrategy _discountStrategy;
        public DiscountService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateDiscount(double amount)
        {
            return _discountStrategy.CalculateDiscount(amount);
        }
    }
}

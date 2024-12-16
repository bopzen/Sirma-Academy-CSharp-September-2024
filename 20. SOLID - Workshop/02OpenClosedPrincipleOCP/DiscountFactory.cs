using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategy(string discountType)
        {
            Dictionary<string, IDiscountStrategy> discountTypes = new Dictionary<string, IDiscountStrategy>
            {
                { "STUDENT", new StudentDiscount() },
                { "SENIOR", new SeniorDiscount() },
                { "SEASONAL", new SeasonalDiscount() }
            };
            if (discountType == null)
            {
                return new NoDiscount();
            }

            return discountTypes[discountType.ToUpper()];
        }
    }
}

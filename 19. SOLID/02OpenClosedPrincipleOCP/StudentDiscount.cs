using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public class StudentDiscount : IDiscoundStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public interface IDiscoundStrategy
    {
        double CalculateDiscount(double price);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class OrderValidator
    {
        public void Validate(Order order)
        {
            if (order.Items.Count == 0)
            {
                throw new Exception("Order has no items");
            }
        }
    }
}

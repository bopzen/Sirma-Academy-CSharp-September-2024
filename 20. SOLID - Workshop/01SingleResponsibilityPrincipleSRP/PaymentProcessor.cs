using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class PaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"{order.TotalAmount} has been paid.");
        }
    }
}

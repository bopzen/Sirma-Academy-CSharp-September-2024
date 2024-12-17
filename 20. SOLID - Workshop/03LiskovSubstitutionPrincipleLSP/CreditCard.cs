using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiskovSubstitutionPrincipleLSP
{
    public class CreditCard : PaymentMethod, IRefundable
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} with CreditCard");
        }

        public void Refund(double amount)
        {
            Console.WriteLine($"Refunded {amount} to Credit Card.");
        }
    }
}

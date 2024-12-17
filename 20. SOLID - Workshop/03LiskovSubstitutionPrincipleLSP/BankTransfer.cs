using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiskovSubstitutionPrincipleLSP
{
    public class BankTransfer : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} with BankTransfer");
        }
    }
}

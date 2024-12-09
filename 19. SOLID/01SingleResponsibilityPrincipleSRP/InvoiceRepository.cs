using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class InvoiceRepository
    {
        public void SaveInvoice(Invoice invoice)
        {
            Console.WriteLine($"{invoice.Id} saved to database");
        }
    }
}

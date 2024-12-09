using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class InvoicePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine($"Printing invoice {invoice.Id}");
        }
    }
}

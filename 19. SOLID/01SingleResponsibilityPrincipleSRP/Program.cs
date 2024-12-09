namespace _01SingleResponsibilityPrincipleSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Zaglavie", "Avtor");
            BookRepository bookRepository = new BookRepository();
            bookRepository.SaveToDatabase(book);

            Invoice invoice = new Invoice(1, 1000, "client");
            InvoiceRepository invoiceRepository = new InvoiceRepository();
            InvoicePrinter invoicePrinter = new InvoicePrinter();
            invoiceRepository.SaveInvoice(invoice);
            invoicePrinter.PrintInvoice(invoice);
        }
    }
}

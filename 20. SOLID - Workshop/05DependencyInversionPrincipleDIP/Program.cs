namespace _05DependencyInversionPrincipleDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmailSender emailSender = new EmailSender();
            IPDFGenerator pdfGenerator = new PDFGenerator();

            var reportGenerator = new ReportGenerator(emailSender, pdfGenerator);
            reportGenerator.GenerateAndSendReport();

            IPaymentProcessor creditCardPaymentProcessor = new CreditCardPaymentProcessor();
            IOrderStorage dbOrderStorage = new DBOrderStorage();
            INotifier emailNotifier = new EmailNotifier();

            var orderService = new OrderService(creditCardPaymentProcessor, dbOrderStorage, emailNotifier);

            var order = new Order
            {
                Items = new List<string> { "Item1", "Item2" },
                TotalAmount = 100.00,
                CustomerEmail = "customer@example.com"
            };

            orderService.PlaceOrder(order);
        }
    }
}

namespace _01SingleResponsibilityPrincipleSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Items = new List<string> { "Item1", "Item2" },
                TotalAmount = 100.0,
                CustomerEmail = "customer@example.com"
            };

            OrderValidator validator = new OrderValidator();
            PaymentProcessor processor = new PaymentProcessor();
            CustomerNotifier notifier = new CustomerNotifier();

            OrderProcessor orderProcessor = new OrderProcessor(validator, processor, notifier);
            orderProcessor.ProcessOrder(order);
        }
    }
}

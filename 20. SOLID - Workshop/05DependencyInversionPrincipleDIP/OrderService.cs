using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class OrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IOrderStorage _orderStorage;
        private readonly INotifier _notifier;

        public OrderService(IPaymentProcessor paymentProcessor, IOrderStorage orderStorage, INotifier notifier)
        {
            _paymentProcessor = paymentProcessor;
            _orderStorage = orderStorage;
            _notifier = notifier;
        }

        public void PlaceOrder(Order order)
        {
            if (order.Items.Count == 0)
            {
                throw new Exception("Order has no items.");
            }
            _paymentProcessor.ProcessPayment(order.TotalAmount);
            _orderStorage.SaveOrder(order);
            _notifier.NotifyCustomer(order.CustomerEmail, "Your order has been placed successfully.");
        }
    }
}

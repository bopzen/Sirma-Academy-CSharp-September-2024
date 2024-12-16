using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class OrderProcessor
    {
        private readonly OrderValidator _orderValidator;
        private readonly PaymentProcessor _paymentProcessor;
        private readonly CustomerNotifier _customerNotifier;

        public OrderProcessor(OrderValidator orderValidator, PaymentProcessor paymentProcessor, CustomerNotifier customerNotifier)
        {
            _orderValidator = orderValidator;
            _paymentProcessor = paymentProcessor;
            _customerNotifier = customerNotifier;
        }

        public void ProcessOrder(Order order)
        {
            _orderValidator.Validate(order);
            _paymentProcessor.ProcessPayment(order);
            _customerNotifier.SendEmailNotification(order);
        }
    }
}

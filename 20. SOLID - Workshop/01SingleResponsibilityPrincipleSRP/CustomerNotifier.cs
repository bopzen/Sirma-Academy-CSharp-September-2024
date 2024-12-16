using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class CustomerNotifier
    {
        public void SendEmailNotification(Order order)
        {
            Console.WriteLine($"Sending email notificatoin to {order.CustomerEmail}");
        }
    }
}

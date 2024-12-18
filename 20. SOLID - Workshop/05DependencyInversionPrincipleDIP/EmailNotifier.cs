using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class EmailNotifier : INotifier
    {
        public void NotifyCustomer(string email, string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}

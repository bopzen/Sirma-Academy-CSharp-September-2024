using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public interface INotifier
    {
        void NotifyCustomer(string email, string message);
    }
}

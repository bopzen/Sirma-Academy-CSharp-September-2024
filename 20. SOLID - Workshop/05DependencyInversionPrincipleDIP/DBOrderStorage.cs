using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class DBOrderStorage : IOrderStorage
    {
        public void SaveOrder(Order order)
        {
            Console.WriteLine("Saving order to database...");
        }
    }
}

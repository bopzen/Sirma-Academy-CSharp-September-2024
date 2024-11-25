using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Contracts
{
    public interface ISellable
    {
        void setPrice(double price);
        double getPrice();

    }
}

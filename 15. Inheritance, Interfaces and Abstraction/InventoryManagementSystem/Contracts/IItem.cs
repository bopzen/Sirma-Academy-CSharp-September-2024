using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Contracts
{
    public interface IItem
    {
        string GetDetails();
        double CalculateValue();
        void DisplayDescription();
    }
}

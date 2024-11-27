using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class ElectronicItem: InventoryItem
    {
        public int WarrantyMonths { get; set; }
        public ElectronicItem(
            int id,
            int quantity,
            string name,
            string description,
            string category,
            double price,
            bool isBreakable,
            bool isPerishable,
            int warrantyMonths
        ) : base(id, quantity, name, description, category, price, isBreakable, isPerishable)
        {
            WarrantyMonths = warrantyMonths;
        }

        public override string GetItemDetails()
        {
            return base.GetItemDetails() + $"Warranty: {WarrantyMonths} Months";
        }
    }
}

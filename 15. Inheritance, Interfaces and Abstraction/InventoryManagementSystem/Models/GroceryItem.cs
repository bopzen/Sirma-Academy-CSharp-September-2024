using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class GroceryItem: InventoryItem
    {
        public DateTime ExpirationDate { get; set; }
        public GroceryItem(
            int id,
            int quantity,
            string name,
            string description,
            string category,
            double price,
            bool isBreakable,
            bool isPerishable,
            DateTime expirationDate
        ) : base(id, quantity, name, description, category, price, isBreakable, isPerishable)
        {
            ExpirationDate = expirationDate;
            IsPerishable = true;
        }

        public override string GetItemDetails()
        {
            return base.GetItemDetails() + $"Best before: {ExpirationDate}";
        }

        public override void HandleExpiration()
        {
            if (DateTime.Now > ExpirationDate)
            {
                Console.WriteLine($"{Name} has expired and is removed from inventory.");
            }
            else
            {
                Console.WriteLine($"{Name} is still valid.");
            }
        }
    }
}

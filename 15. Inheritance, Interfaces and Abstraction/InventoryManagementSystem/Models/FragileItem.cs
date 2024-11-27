using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class FragileItem : InventoryItem
    {
        public double Weight { get; set; }
        public FragileItem(
            int id,
            int quantity,
            string name,
            string description,
            string category,
            double price,
            bool isBreakable,
            bool isPerishable,
            double weight
        ) : base(id, quantity, name, description, category, price, isBreakable, isPerishable)
        {
            Weight = Weight;
            IsBreakable = true;
        }
        public override void HandleBreakage()
        {
            Console.WriteLine($"{Name} is fragile and has been marked as broken.");
            Quantity = 0;
        }
    }
}

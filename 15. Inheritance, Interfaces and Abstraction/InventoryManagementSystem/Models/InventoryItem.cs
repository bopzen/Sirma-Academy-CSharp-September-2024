using InventoryManagementSystem.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class InventoryItem : AbstractItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(
            int id, 
            int quantity, 
            string name, 
            string description, 
            string category, 
            double price, 
            bool isBreakable, 
            bool isPerishable) : base(name, description, category, price, isBreakable, isPerishable) 
        {
            Id = id;
            Quantity = quantity;
        }
        public override string GetItemDetails()
        {
            return $"Item ID: {Id}, Item Name: {Name}, Description: {Description}, Category: {Category}, Price: {Price}, Quantity: {Quantity}";
        }

        public void IncreaseQuantity(int amount)
        {
            Quantity += amount;
        }

        public void DecreaseQuantity(int amount)
        {
            if (Quantity >= amount)
            {
                Quantity -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient stock!");
            }
                
        }
    }
}

using InventoryManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Abstractions
{
    public abstract class AbstractItem : IItem, ICategorizable, IBreakable, IPerishable, ISellable
    {   
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsBreakable { get; set; }
        public bool IsPerishable { get; set; }

        public AbstractItem(string name, string description, string category, double price, bool isBreakable, bool isPerishable)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            IsBreakable = isBreakable;
            IsPerishable = isPerishable;
        }

        public double CalculateValue()
        {
            return Price;
        }

        public void DisplayDescription()
        {
            Console.WriteLine(Description);
        }
        public string GetDetails()
        {
            return $"Name: {Name}, Description: {Description}, Category: {Category}, Price: {Price}";
        }

        public string GetCategory()
        {
            return Category;
        }
        public void SetCategory(string category)
        {
            Category = category;
        }


        public double GetPrice()
        {
            return Price;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }

        public bool IsItemBreakable()
        {
            return IsBreakable;
        }
        public virtual void HandleBreakage()
        {
            Console.WriteLine($"{Name} has been marked as broken.");
        }
        public bool IsItemPerishable()
        {
            return IsPerishable;
        }

        public virtual void HandleExpiration()
        {
            Console.WriteLine($"{Name} has expired and needs to be removed.");  
        }

        public abstract string GetItemDetails();
    }
}

using InventoryManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Abstractions
{
    public class AbstractItem : IItem, ICategorizable, IBreakable, IPerishable, ISellable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsBreakable { get; set; }
        public bool IsPerishable { get; set; }
        public bool IsSellable { get; set; }

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
            return $"Item ID: {Id}, Name: {Name}, Description: {Description}, Category: {Category}, Price: {Price}";
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

        public bool IsBreakable()
        {
            return IsBreakable;
        }
        public void HandleBreakage()
        {
            throw new NotImplementedException();
        }
        public bool IsPerishable()
        {
            throw new NotImplementedException();
        }

        public void HandleExpiration()
        {
            throw new NotImplementedException();
        }
    }
}

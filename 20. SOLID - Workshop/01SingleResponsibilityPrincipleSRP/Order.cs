using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class Order
    {
        public List<string> Items { get; set; } = new List<string>();
        public double TotalAmount { get; set; }
        public string CustomerEmail { get; set; }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class Invoice
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string CustomerName { get; set; }

        public Invoice(int id, double amount, string customerName)
        {
            Id = id;
            Amount = amount;
            CustomerName = customerName;
        }
    }

}

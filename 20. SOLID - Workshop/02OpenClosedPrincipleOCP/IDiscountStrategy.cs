﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);  
    }
}
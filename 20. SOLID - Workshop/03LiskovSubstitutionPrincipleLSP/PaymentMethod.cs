﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiskovSubstitutionPrincipleLSP
{
    public abstract class PaymentMethod
    {
        public abstract void Pay(double amount);
    }
}

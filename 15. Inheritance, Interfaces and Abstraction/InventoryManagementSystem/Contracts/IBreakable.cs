﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Contracts
{
    public interface IBreakable
    {
        bool IsItemBreakable();
        void HandleBreakage();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public interface ITemperatureControl
    {
        void SetTemperature(int temperature);
    }
}
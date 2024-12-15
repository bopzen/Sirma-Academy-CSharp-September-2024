using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class TemperatureSensor : ITemperatureSensor
    {
        public double GetTemperature()
        {
            return 25.0;
        }
    }
}

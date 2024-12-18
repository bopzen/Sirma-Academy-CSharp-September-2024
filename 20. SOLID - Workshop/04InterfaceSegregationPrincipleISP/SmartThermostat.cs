using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public class SmartThermostat : IPowerDevice, ITemperatureControl
    {
        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"Smart THermostat temperature set to {temperature}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Smart THermostat is turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Smart THermostat is turned on.");
        }
    }
}

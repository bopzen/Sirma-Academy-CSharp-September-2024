using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public class SmartLight : IPowerDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Smart Light is turned on.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Smart Light is turned off.");
        }
    }
}

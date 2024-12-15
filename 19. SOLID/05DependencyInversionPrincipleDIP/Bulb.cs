using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class Bulb : ISwitchable
    {
        public bool IsOn { get; private set; } = false;
        public void TurnOff()
        {
            if (IsOn)
            {
                Console.WriteLine("Turn off bulb.");
                IsOn = false;
            }
        }

        public void TurnOn()
        {
            if (!IsOn)
            {
                Console.WriteLine("Turn on bulb.");
                IsOn = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class LightSwitch
    {
        private readonly ISwitchable _device;

        public LightSwitch(ISwitchable switchable)
        {
            _device = switchable;
        }

        public void Operate()
        {
            if (_device.IsOn)
            {
                _device.TurnOff();
            }
            else
            {
                _device.TurnOn();
            }
        }
    }
}

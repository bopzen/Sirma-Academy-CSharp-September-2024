using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public interface ISwitchable
    {
        bool IsOn { get; }
        void TurnOn();
        void TurnOff();
    }
}

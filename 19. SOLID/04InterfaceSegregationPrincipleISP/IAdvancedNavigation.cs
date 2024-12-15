using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public interface IAdvancedNavigation
    {
        void Next();
        void Previous();
        void Shuffle();
    }
}

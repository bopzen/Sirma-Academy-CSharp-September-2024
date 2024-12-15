using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    internal interface IMultiFunctionDevice : IPrinter, IFax, IScanner
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public class MultiFunctionalDevice : IMultiFunctionDevice
    {
        public void Print()
        {
            Console.WriteLine("MFD is printing...");
        }

        public void Scan()
        {
            Console.WriteLine("MFD is sending fax...");
        }

        public void SendFax()
        {
            Console.WriteLine("MFD is scanning...");
        }
    }
}

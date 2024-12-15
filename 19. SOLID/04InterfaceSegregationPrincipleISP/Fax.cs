using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public class Fax : IFax
    {
        public void SendFax()
        {
            Console.WriteLine("Sending Fax...");
        }
    }
}

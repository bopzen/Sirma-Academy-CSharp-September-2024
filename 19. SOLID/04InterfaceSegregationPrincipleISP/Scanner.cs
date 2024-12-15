using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }
    }
}

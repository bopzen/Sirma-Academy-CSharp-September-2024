using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiskovSubstitutionPrincipleLSP
{
    public class CombustionEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Combustion engine started.");
        }
    }
}

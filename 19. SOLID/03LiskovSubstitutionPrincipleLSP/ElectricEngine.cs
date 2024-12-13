using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiskovSubstitutionPrincipleLSP
{
    public class ElectricEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Electric engine started.");
        }
    }
}

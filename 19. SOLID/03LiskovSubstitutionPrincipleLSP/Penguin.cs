using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiskovSubstitutionPrincipleLSP
{
    public class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Penguin is moving.");
        }
    }
}

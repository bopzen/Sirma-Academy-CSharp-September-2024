using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LiskovSubstitutionPrincipleLSP
{
    public class Eagle : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Eagle is flying.");
        }

        public override void Move()
        {
            Console.WriteLine("Eagle is moving.");
        }
    }
}

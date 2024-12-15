using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public class SimplePlayer : IBasicPlayer
    {
        public void Pause()
        {
            Console.WriteLine("Pause music...");
        }

        public void Play()
        {
            Console.WriteLine("Play music...");
        }
    }
}

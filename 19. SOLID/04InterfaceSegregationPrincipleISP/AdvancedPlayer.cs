using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregationPrincipleISP
{
    public class AdvancedPlayer : IAdvancedPlayer
    {
        public void Next()
        {
            Console.WriteLine("Play next song...");
        }

        public void Pause()
        {
            Console.WriteLine("Pause music...");
        }

        public void Play()
        {
            Console.WriteLine("Play music...");
        }

        public void Previous()
        {
            Console.WriteLine("Play previous song...");
        }

        public void Shuffle()
        {
            Console.WriteLine("Shuffle songs...");
        }
    }
}

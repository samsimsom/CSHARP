
using static System.Console;

namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Play()
        {
            WriteLine("DVD player is playing.");
        }

        public void Pause()
        {
            WriteLine("Dvd player is pausing.");
        }
    }
}
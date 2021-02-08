using System;

namespace BlazorWAProject.Pages
{
    public partial class RandomNumberGenerator
    {
        private int Number { get; set; }

        private void RandomNumber()
        {
            var rnd = new Random();
            Number = rnd.Next();
        }
    }
}
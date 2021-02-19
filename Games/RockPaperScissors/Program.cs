using System;
using static System.Console;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            var game = new Game();
            game.Run();
            
        }
    }
}
using System;
using static System.Console;

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new RandomNumberGame();
            
            Clear();
            game.EmptyLine();
            game.DottedLine();
            game.EmptyLine();
            
            game.ColorfullText(ConsoleColor.Yellow, 
                "Random Number Guessing Game!",
                0);
            
            game.EmptyLine();
            game.DottedLine();
            
            // GAME START
            game.Game();
            // GAME END
            
        }
    }
}

using System;
using System.Globalization;
using static System.Console;

namespace RockPaperScissors
{
    public class Game
    {
        private enum Move { Rock, Paper, Scissors }
        
        // ---------------------------------------------------------------------
        public void Run()
        {
            var random = new Random();
            var wins = 0;
            var losses = 0;

            while (true)
            {
                Clear();
                TitleDisplay();
                
                GetInput:
                Write("Choose [r]ock, [p]aper, [s]cissors, or [e]xit : ");

                Move playerMove;
                switch (ReadLine().ToLower())
                {
                    case "rock" or "r": playerMove = Move.Rock; break;
                    case "paper" or "p": playerMove = Move.Paper; break;
                    case "scissors" or "s": playerMove = Move.Scissors; break;
                    case "exit"or "e": Clear(); return;
                    default: WriteLine("Invalid Input. Try Again..."); goto GetInput;
                }

                var computerMove = (Move) random.Next(3);
                WriteLine($"The computer chose {computerMove}");
                WriteLine($"Player move {playerMove}");
                switch (playerMove, computerMove)
                {
                    case (Move.Rock, Move.Paper):
                    case (Move.Paper, Move.Scissors):
                    case (Move.Scissors, Move.Rock):
                        WriteLine("You Lose.");
                        losses++;
                        break;
                    case (Move.Paper, Move.Rock):
                    case (Move.Scissors, Move.Paper):
                    case (Move.Rock, Move.Scissors):
                        WriteLine("You Win.");
                        wins++;
                        break;
                    default:
                        WriteLine("This game was a draw.");
                        break;
                }
                WriteLine($"Score: {wins} wins, {losses} losses");
                WriteLine("Press enter to continue...");
                ReadLine();
            }
            
        }

        // ---------------------------------------------------------------------
        private void TitleDisplay()
        {
            WriteLine(new string('-', 35));
            WriteLine("--- Rock - Paper - Scissors ---");
            WriteLine(new string('-', 35));
            WriteLine();
        }
        // ---------------------------------------------------------------------

    }
}
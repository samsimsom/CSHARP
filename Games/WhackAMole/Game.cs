
using System;
using static System.Console;

namespace WhackAMole
{
    public class Game
    {
        public void Run()
        {
            // visual variables ------------------------------------------------
            var board =
                @" ╔═══╦═══════╗ ╔═══╦═══════╗ ╔═══╦═══════╗" + '\n' +
                @" ║ 7 ║       ║ ║ 8 ║       ║ ║ 9 ║       ║" + '\n' +
                @" ╚═══╣       ║ ╚═══╣       ║ ╚═══╣       ║" + '\n' +
                @"     ║       ║     ║       ║     ║       ║" + '\n' +
                @"     ║       ║     ║       ║     ║       ║" + '\n' +
                @"     ╚═══════╝     ╚═══════╝     ╚═══════╝" + '\n' +
                @" ╔═══╦═══════╗ ╔═══╦═══════╗ ╔═══╦═══════╗" + '\n' +
                @" ║ 4 ║       ║ ║ 5 ║       ║ ║ 6 ║       ║" + '\n' +
                @" ╚═══╣       ║ ╚═══╣       ║ ╚═══╣       ║" + '\n' +
                @"     ║       ║     ║       ║     ║       ║" + '\n' +
                @"     ║       ║     ║       ║     ║       ║" + '\n' +
                @"     ╚═══════╝     ╚═══════╝     ╚═══════╝" + '\n' +
                @" ╔═══╦═══════╗ ╔═══╦═══════╗ ╔═══╦═══════╗" + '\n' +
                @" ║ 1 ║       ║ ║ 2 ║       ║ ║ 3 ║       ║" + '\n' +
                @" ╚═══╣       ║ ╚═══╣       ║ ╚═══╣       ║" + '\n' +
                @"     ║       ║     ║       ║     ║       ║" + '\n' +
                @"     ║       ║     ║       ║     ║       ║" + '\n' +
                @"     ╚═══════╝     ╚═══════╝     ╚═══════╝";
            
            var javaNoob =
                @" ╔══─┐ " + '\n' +
                @" │o-o│ " + '\n' +
                @"┌└───┘┐" + '\n' +
                @"││ J ││";

            var empty =
                @"       " + '\n' +
                @"       " + '\n' +
                @"       " + '\n' +
                @"       ";
            // visual variables ------------------------------------------------

            var playTime = TimeSpan.FromSeconds(30);
            SetConsoleSize();

            while (true)
            {
                Clear();
                WriteLine("Whack A Mole (Java Noob Edition)");
                WriteLine();
                WriteLine($"You have {(int)playTime.TotalSeconds} seconds to " +
                          $"whack as many Java noobs as you can \nbefore the timer " +
                          $"runs out. Use the number keys 1-9 to whack.\n" +
                          $"Are you ready?");
                WriteLine();
                WriteLine("Play [Enter] or Quit [Esc]?");
                
                GetInput:
                switch (ReadKey(true).Key)
                {
                    case ConsoleKey.Enter:
                        Play(board, playTime);
                        break;
                    case ConsoleKey.Escape:
                        Clear();
                        WriteLine("Whack A Mole was closed...");
                        Environment.Exit(0);
                        break;
                    default: goto GetInput;
                }
            }
        }

        private void Play(string board, TimeSpan playTime)
        {
            Clear();
            WriteLine("Whack A Mole (Java Noob Edition)");
            WriteLine();
            WriteLine(board);
            var start = DateTime.Now;
            var score = 0;
            var random = new Random();
            var moleLocation = random.Next(1, 10);
            CursorVisible = false;

            while (DateTime.Now - start < playTime)
            {
            }
            
        }
        
        private void SetConsoleSize()
        {
            if (OperatingSystem.IsWindows())
            {
                WindowWidth = Math.Max(WindowWidth, 50);
                WindowHeight = Math.Max(WindowHeight, 22);
            }
        }
    }
}
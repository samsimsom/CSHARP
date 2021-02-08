using System;
using System.Diagnostics;
using System.IO.Compression;
using HelpersLibrary;

namespace MethodConsoleApp
{
    public class RollDice
    {
        public void RollingDice()
        {
            Helpers helpers = new Helpers();
            Random rnd = new Random();
            
            int frequency1 = 0;
            int frequency2 = 0;
            int frequency3 = 0;
            int frequency4 = 0;
            int frequency5 = 0;
            int frequency6 = 0;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var loopCounter = 6_000_000;
            for (int roll = 1; roll <= loopCounter; roll++)
            {
                int face = rnd.Next(1, 7);

                switch (face)
                {
                    case 1:
                        ++frequency1;
                        break;
                    case 2:
                        ++frequency2;
                        break;
                    case 3:
                        ++frequency3;
                        break;
                    case 4:
                        ++frequency4;
                        break;
                    case 5:
                        ++frequency5;
                        break;
                    case 6:
                        ++frequency6;
                        break;
                }
            }

            stopWatch.Stop();
            
            
            helpers.Seperator('-', 30);
            helpers.Colorize(ConsoleColor.DarkMagenta, "Face\tFrequency");
            Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
            Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
            Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");
            Console.WriteLine($"\nTotal Time: {stopWatch.Elapsed}");
            helpers.Seperator('-', 30);
            
        }
    }
}
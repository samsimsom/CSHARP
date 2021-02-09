
using System.Diagnostics;
using System;
using System.Linq;
using static System.Console;

namespace Sorting
{
    public class Bubble
    {
        public void BubbleSort(int[] data)
        {

            var rnd = new Random();
            int[] shuffeldData = data.OrderBy(x => rnd.Next()).ToArray();

            var exchange = new Exchage();
            var stopWatch = new Stopwatch();

            ForegroundColor = ConsoleColor.Blue;
            WriteLine("BEFORE Bubble Sorting :");
            WriteLine(string.Join('-', shuffeldData));
            ResetColor();

            stopWatch.Start();
            // Bubble Sorting START
            int i, j;
            int dataLenght = shuffeldData.Length;
            for (j = dataLenght - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (shuffeldData[i] > shuffeldData[i + 1])
                    {
                        exchange.ExchageInt(shuffeldData, i, i + 1);
                    }
                }
            }
            // Bubble Sorting END
            stopWatch.Stop();
            
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("AFTER Bubble Sorting :");
            WriteLine(string.Join("-", shuffeldData));
            ResetColor();
            
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Time elapsed : {stopWatch.Elapsed}");
            ResetColor();
        
        }
    }
}
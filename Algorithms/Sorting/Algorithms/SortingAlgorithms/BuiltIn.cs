
using Exchange;
using System;
using System.Diagnostics;
using System.Linq;
using static System.Console;

namespace SortingAlgorithms
{
    public class BuiltIn
    {
        public void BuiltInSort(int[] data)
        {
            var rnd = new Random();
            int[] shuffeldData = data.OrderBy(x => rnd.Next()).ToArray();

            var exchange = new Exchage();
            var stopWatch = new Stopwatch();

            ForegroundColor = ConsoleColor.Blue;
            WriteLine("BEFORE Built-in Sorting :");
            WriteLine(string.Join('-', shuffeldData));
            ResetColor();

            stopWatch.Start();
            // Built-in Sort START
            Array.Sort(shuffeldData);
            // Built-in sort END
            stopWatch.Stop();

            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("AFTER Built-in Sorting :");
            WriteLine(string.Join("-", shuffeldData));
            ResetColor();
            
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Time elapsed : {stopWatch.Elapsed}");
            ResetColor();
        }
    }
}
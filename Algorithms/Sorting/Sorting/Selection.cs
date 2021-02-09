
using System;
using System.Diagnostics;
using static System.Console;

namespace Sorting
{
    public class Selection
    {

        private static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
            {
                if (data[pos] < data[minPos])
                {
                    minPos = pos;
                }
            }
            return minPos;
        }

        public void SelectionSort(int[] data)
        {
            var exchange = new Exchage();
            var stopWatch = new Stopwatch();

            ForegroundColor = ConsoleColor.Blue;
            WriteLine("BEFORE Selection Sorting :");
            WriteLine(string.Join('-', data));
            ResetColor();

            stopWatch.Start();
            // Selection Sorting START
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                {
                   exchange.ExchageInt(data, i, k); 
                }
            }
            // Selection Sorting END
            stopWatch.Stop();

            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("AFTER Selection Sorting :");
            WriteLine(string.Join('-', data));
            ResetColor();

            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Time elapsed : {stopWatch.Elapsed}");
            ResetColor();
            
        }

    }
}

using System.Diagnostics;
using Exchange;
using static System.Console;

namespace SortingAlgorithms
{
    public class Bubble
    {
        public void BubbleSort(int[] data)
        {
            var exchange = new Exchage();
            var stopWatch = new Stopwatch();

            WriteLine("BEFORE Bubble Sorting :");
            WriteLine(string.Join('-', data));
            
            stopWatch.Start();
            // Bubble Sorting START
            int i, j;
            int dataLenght = data.Length;
            for (j = dataLenght - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        exchange.ExchageValues(data, i, i + 1);
                    }
                }
            }
            // Bubble Sorting END
            stopWatch.Stop();
            
            WriteLine("AFTER Bubble Sorting :");
            WriteLine(string.Join("-", data));
            WriteLine($"Time elapsed : {stopWatch.Elapsed}");
        }
    }
}
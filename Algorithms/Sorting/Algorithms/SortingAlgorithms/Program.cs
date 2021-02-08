using System;
using Exchange;
using VisualUtils;
using static System.Console;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Helper();
            
            helper.CleanScreen();
            WriteLine("Hello World!");
            helper.LineSeperator();

            var exchange = new Exchage();

            // Array
            int[] data = new[] {1, 23, 44, 22, 76, 49, 85, 34, 2, 4, 8};
            
            WriteLine("Array BEFORE Bubble Sorting :");
            WriteLine(string.Join('-', data));
            
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

            WriteLine("Arrat AFTER Bubble Sorting :");
            WriteLine(string.Join("-", data));

        }
    }
}

using System;
using Helper;
using static System.Console;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Visual();
            
            helper.CleanScreen();
            WriteLine("-- Sorting Algorithms --");
            helper.LineSeperator();

            // Random generated int Array
            int[] data = new int[10];
            var rnd = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(0, 500);
            }

            // Built-in Sorting Algorithm
            var builtinShort = new BuiltIn();
            builtinShort.BuiltInSort(data);
            helper.LineSeperator();

            // Bubble Sorting Algorithm
            var bubble = new Bubble();
            bubble.BubbleSort(data);
            helper.LineSeperator();

            // Selection Sorting Algorithm
            var selection = new Selection();
            selection.SelectionSort(data);
            helper.LineSeperator();

        }
    }
}
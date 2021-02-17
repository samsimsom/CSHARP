using System;
using static System.Console;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--- While Loop ---");
            WriteLine();            // Empty line

            var interactiveWhileLoop = new InteractiveWhileLoop();
            interactiveWhileLoop.InputIntInRange("Enter an Int", 0, 100);

        }
    }
}
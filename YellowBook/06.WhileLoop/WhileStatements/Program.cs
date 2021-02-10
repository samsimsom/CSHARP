
using System;
using static System.Console;
namespace WhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            var ws = new WhileStatementsClass();               // Instance

            // Clear();
            WriteLine("--- While Statements ---");
            WriteLine(new string('-', 35));

            // -----------------------------------------------------------------
            // ws.DropTeaTemperature();
            // WriteLine(new string('-', 35));
            // -----------------------------------------------------------------

            // -----------------------------------------------------------------
            // ws.ExplosiveTimer();
            // WriteLine(new string('-', 35));
            // -----------------------------------------------------------------

            // -----------------------------------------------------------------
            // WriteLine($"Sum of N numbers : {ws.SumtoN(byte.MaxValue)}");
            // ws.SumToNSecond(byte.MaxValue);
            // WriteLine(new string('-', 35));
            // -----------------------------------------------------------------

            // -----------------------------------------------------------------
            // ws.OneChrPerLine("bug");
            // WriteLine(new string('-', 35));
            // -----------------------------------------------------------------

            // -----------------------------------------------------------------
            ws.PrintVovels("substitutEs");
            WriteLine(new string('-', 35));
            // -----------------------------------------------------------------
        }
    }
}


using System;
using static System.Console;

namespace WhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            var ws = new WhileStatementsClass();                // Instance

            Clear();
            WriteLine("--- While Statements ---");
            WriteLine(new string('-', 35));                     // LineSeperator

            // -----------------------------------------------------------------
            ws.DropTeaTemperature();
            WriteLine(new string('-', 35));                     // LineSeperator
            // -----------------------------------------------------------------

        }
    }
}


using System;
using System.IO;
using System.Diagnostics;
using static System.Console;

namespace Helper
{
    public class Visual
    {
        public void CleanScreen()
        {
            try
            {
                Clear();
            }
            catch (IOException)
            {
                WriteLine("Clear Console!");
            }
        }

        public void LineSeperator()
        {
            WriteLine(new string('-', 35));
        }
    }
}

using System;
using static  System.Console;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();

            object o = 10;      // object 0 = "10";
            int j = 4;

            if (o is int i)     //o int tipinde bir degisken ise local i ye ata.
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }
        }
    }
}
using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            var b = a++;

            var c = 3;
            var d = ++c;

            WriteLine($"a is {a}, b is {b}");
            WriteLine($"c is {c}, d is {d}");
        }
    }
}
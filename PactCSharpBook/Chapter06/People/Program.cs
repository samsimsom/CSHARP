using System;
using static System.Console;

namespace People
{
    class Program
    {
        public static string Name { get; set; } = "Kitty";
        
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            WriteLine($"Hello {Name}");
        }
    }
}
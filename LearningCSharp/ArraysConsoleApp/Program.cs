using System;
using HelpersLibrary;

namespace ArraysConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var helpers = new Helpers();
            
            helpers.ConsoleCleaner();
            
            helpers.Title("Arrays");

            Console.WriteLine("Hello Kitty!");
            Console.WriteLine("Temperature on {0:D} is {1}°C", 
                DateTime.Today, 23.4);
            
            helpers.ConsoleStoper();
        }
    }
} 
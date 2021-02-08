using System;

namespace InputConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!, I'm Computer!");
            Console.Write("What is your name?\n");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}. Nice to meet you.");

        }
    }
}
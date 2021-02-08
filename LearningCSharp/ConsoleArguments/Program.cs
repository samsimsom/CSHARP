using System;

namespace ConsoleArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Arguments!");

            var argumentClass = new ArgumantClass();
            argumentClass.InputArgument(args);
            
        }
    }
}
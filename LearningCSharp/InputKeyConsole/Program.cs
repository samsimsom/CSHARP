using System;

namespace InputKeyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GET USER KEY INPUT");

            var getInput = new GetInput();
            getInput.UserInput();
        }
    }
}
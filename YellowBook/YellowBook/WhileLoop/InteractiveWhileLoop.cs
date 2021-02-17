
using System;
using static System.Console;

namespace WhileLoop
{
    public class InteractiveWhileLoop
    {
        private int InputInt(string info)
        {
            Write(info);
            return Int32.Parse(ReadLine());
        }

        public int InputIntInRange(string prompt, int lowLim, int highLim )
        {
            string longPrompt = $"{prompt} ({lowLim} - {highLim}) : ";
            int number = InputInt(longPrompt);

            while (number < lowLim || number > highLim)
            {
                WriteLine($"{number} is out of range!");
            }

            return number;
        }
    }
}
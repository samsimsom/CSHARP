
using System;
using static System.Console;

namespace DivisionTwoNumbers
{
    public class Division
    {
        private int NumberOne { get; set; }
        private int NumberTwo { get; set; }

        public void Userinput()
        {
            while (true)            // First number check loop!
            {
                Write("Enter a number between 0 to 255: ");
                string inputOne = ReadLine();

                if (int.TryParse(inputOne, out int iInputOne))
                {        
                    if (iInputOne < 0 || iInputOne > 255)
                    {
                        WriteLine($"Between 0 to 255");
                    }
                    else
                    {
                        NumberOne = iInputOne;
                        break;
                    }
                }
                else
                {
                    WriteLine($"Just enter a number!");
                }
            }

            while (true)            // Second number check loop!
            {
                Write("Enter another number between 0 to 255: ");
                string inputTwo = ReadLine();

                if (int.TryParse(inputTwo, out int iInputTwo))
                {        
                    if (iInputTwo < 0 || iInputTwo > 255)
                    {
                        WriteLine($"Between 0 to 255");
                    }
                    else
                    {
                        NumberTwo = iInputTwo;
                        break;
                    }
                }
                else
                {
                    WriteLine($"Just enter a number!");
                }
            }
        }

        public void NumberDivision()
        {
            try
            {
                var result = NumberOne / NumberTwo;
                WriteLine($"{NumberOne} divided by {NumberTwo} is " +
                          $"{result}");
            }
            catch (DivideByZeroException e)
            {
                WriteLine($"Zero Division Exception : {e.Message}");
            }
        }
    }
}
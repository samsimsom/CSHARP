
using System;
using System.Runtime.Serialization;
using static System.Console;

namespace WritingFunctions
{
    public class Functions
    {
        private void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table.");

            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }

        public void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255\n");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You didnot enter a valid number!");
                }

            } while (isNumber);
        }
        
        //----------------------------------------------------------------------
        
        private decimal CalculateTax(decimal amount, 
            string twoLetterRegistrationCode)
        {
            decimal rate = 0.0m;
            switch (twoLetterRegistrationCode)
            {
                case "CH":
                    rate = 0.08m;
                    break;
                case "DK":
                case "NO":
                    rate = 0.25m;
                    break;
                case "FR":
                    rate = 0.10m;
                    break;
                default:
                    rate = 0.06m;
                    break;
            }
            return amount * rate;
        }

        public void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            
            Write("Enter a two-letter region code: ");
            string reginCode = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, reginCode);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not anter a valid amount!");
            }
        }
        
        //----------------------------------------------------------------------

        private string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;
                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }

        public void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }
        
        //----------------------------------------------------------------------

        private int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                checked // for owerflow!
                {
                    return number * Factorial(number - 1);
                }
            }
        }

        public void RunFactorial()
        {
            for (int i = 1; i < 15; i++)
            {
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (System.OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer.");
                }
            }
        }
        
        //----------------------------------------------------------------------

        private int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            else if (term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term - 1) + 
                       FibImperative(term - 2);
            }
        }

        public void RunFibImperative()
        {
            for (int i = 1; i <= 30; i++)
            {
                WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci" +
                          $" sequence is {FibImperative(term: i):N0}");
            }
        }
        
        //----------------------------------------------------------------------

        private int FibFunctional(int term) =>
            term switch
            {
                1 => 0,
                2 => 1,
                _ => FibFunctional(term - 1) + FibFunctional(term - 2)
            };

        public void RunFibFunctional()
        {
            for (int i = 1; i <= 30; i++)
            {
                WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci " +
                          $"sequence is {FibFunctional(term: i):N0}");
            }
        }

        //----------------------------------------------------------------------

    }
}
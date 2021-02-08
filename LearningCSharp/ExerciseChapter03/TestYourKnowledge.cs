using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using static System.Console;

namespace ExerciseChapter03
{
    public class TestYourKnowledge
    {
        public void E1()
        {
            int a = 10;
            int b = 0;
            Console.WriteLine($"Int Zero Division" +
                              $"{a / b}");
        }

        public void E2()
        {
            double dA = 10.0;
            double dB = 0.0;

            Console.WriteLine($"Double zero division:" +
                              $" {dA / dB}");
        }

        public void E3()
        {
            int number = int.MaxValue;
            number++;

            Console.WriteLine(number);
        }

        public void E4()
        {
            int number1 = 10;
            int number2 = 10;

            Console.WriteLine(number1++); // after increment
            Console.WriteLine(++number2); // before increment
        }

        public void E5()
        {
            // break
            // continue
            // return
            string input = Console.ReadLine();
            
            while (input != "q")
            {
                if (input == "a")
                {
                    Console.WriteLine("break!");
                    break;
                }
                else if (input == "b")
                {
                    Console.WriteLine("continue");
                    continue;
                }
                else if (input == "c")
                {
                    Console.WriteLine("return");
                    return;
                }
            }
            
        }

        public void E6()
        {
            for ( ; true;) ;
        }

        public void E7()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                if (max > byte.MaxValue)
                {
                    Console.WriteLine($"Max iteration value {max} " +
                                      $"bigger than control value!");
                    break;
                }
                
                Console.WriteLine(i);
            }
        }

        public void E8()
        {
            // New list
            var fizzBuzz = new List<string>();
            
            // List content creator
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {;
                    fizzBuzz.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    fizzBuzz.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    fizzBuzz.Add("Buzz");
                }
                else
                {
                    fizzBuzz.Add(Convert.ToString(i));
                }
            }
            
            // Output list with comma seperator
            string output = string.Join(",", fizzBuzz);
            Console.Write(output);
        }

        public void E9()
        {
            // get lower case string input
            WriteLine("INFO");
            WriteLine("Press Q after Enter for Quit");
            WriteLine(new string('-', 35));
            
            
            
            while (true)
            {
                byte bInputOne = default(byte);
                byte bInputTwo = default(byte);
                
                FirstNumber:
                Write("Enter a number between 0 and 255: ");
                string inputOne = ReadLine().ToLower();
                if (inputOne == "q")
                {
                    break;
                }
                bInputOne = CheckFormat(inputOne);
                if (bInputOne == 0)
                {
                    goto FirstNumber;
                }

                SecondNumber:
                Write("Enter another number between 0 and 255: ");
                string inputTwo = ReadLine().ToLower();
                
                if (inputTwo == "q")
                {
                    break;
                }
                bInputTwo = CheckFormat(inputTwo);
                if (bInputTwo == 0)
                {
                    goto SecondNumber;
                }
                
                WriteLine($"{bInputOne} divided by {bInputTwo} is " +
                          $"{bInputOne / bInputTwo}");
                
            }
        }

        private byte CheckFormat(string input)
        {
            byte bNumber = default(byte);
            
            try
            {
                bNumber = byte.Parse(input);
            }
            catch (FormatException e)
            {
                WriteLine($"FormatException: {e.Message}");
            }

            return bNumber;
        }

        public void E10()
        {
            int x = 3;
            int y = 2 + ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(new string('-', 35));
            
            int a = 3 << 2;
            int b = 10 >> 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            Console.WriteLine(new string('-', 35));

            int c = 10 & 8;
            int d = 10 | 7;
            Console.WriteLine(c);
            Console.WriteLine(b);
        }
        
        
    }
}
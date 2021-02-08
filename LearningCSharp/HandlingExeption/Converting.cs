
using System;
using static System.Console;

namespace HandlingExeption
{
    public class Converting
    {
        //----------------------------------------------------------------------

        public void ConvertingExampleOne()
        {
            
            /*
             * ToString method converts the current value of
             * any variable into a textual representation.
             */
            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());
            
            DateTime now = DateTime.Now;
            WriteLine(now);

            object me = new object();
            WriteLine(me.ToString());
        }
        
        //----------------------------------------------------------------------

        public void ConvertingExampleTwo()
        {
            byte[] binaryObject = new byte[128];
            
            (new Random()).NextBytes(binaryObject);
            
            WriteLine("Binary Object as bytes: ");

            for (int i = 0; i < binaryObject.Length; i++)
            {
                Write($"{binaryObject[i]:X} ");
            }
            WriteLine();

            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"binary Object as Base64: {encoded}");
        }
        
        //----------------------------------------------------------------------

        public void ConvertingExampleThree()
        {
            int age = int.Parse("36");
            DateTime birthday = DateTime.Parse("15 December 1984");
            
            WriteLine($"I was born {age} years ago!");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");
            
            // one problem with the parse method is that it gives errors
            // if the string cannot be converted.
        }
        
        //----------------------------------------------------------------------

        public void ConvertingExampleFour()
        {
            Write("How many eggs in there? : ");
            int count;
            string input = ReadLine();

            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input!");
            }
        }
        
        //----------------------------------------------------------------------

        public void HandlingExeptionOne()
        {
            WriteLine("Before Parsing");
            Write("What is your age? : ");
            string input = ReadLine();

            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old!");
            }
            catch (Exception e)
            {
                WriteLine($"{e.GetType()} says {e.Message}");
            }
            WriteLine("After Parsing");
        }
        
        //----------------------------------------------------------------------

        public void HandlingExeptionTwo()
        {
            Write("Enter your age or quit for q: ");
            string input = ReadLine();

            while (input != "q")
            {
                try
                {
                    int age = int.Parse(input);
                    WriteLine($"You are {age} years old!");
                }
                catch (FormatException)
                {
                    WriteLine("The age you entered is not a valid number " +
                              "format.");
                }
                catch (OverflowException)
                {
                    WriteLine("Your age is a valid number format but it is " +
                              "either too big or small.");
                }
                catch (Exception e)
                {
                    WriteLine($"{e.GetType()} says {e.Message}");
                }
                
                Write("Enter your age or quit for q: ");
                input = ReadLine();

            }
        }
        
        //----------------------------------------------------------------------

        public void HandlingExeptionThree()
        {
            // Throwing overflow exeptions with the checked statement

            #region First

            int x = int.MaxValue - 1;
            WriteLine($"initial value: {x}");

            x++;
            WriteLine($"After incrimenting: {x}");
            x++;
            WriteLine($"After incrimenting: {x}");
            x++;
            WriteLine($"After incrimenting: {x}");
            
            #endregion

            WriteLine(new string('-', 35));
            
            #region Second

            checked
            {
                int y = int.MaxValue - 1;
                WriteLine($"initial value: {y}");

                y++;
                WriteLine($"After incrimenting: {y}");
                y++;
                WriteLine($"After incrimenting: {y}");
                y++;
                WriteLine($"After incrimenting: {y}");
            }

            #endregion

            WriteLine(new string('-', 35));

            #region Third

            try
            {
                int z = int.MaxValue - 1;
                WriteLine($"initial value: {z}");

                z++;
                WriteLine($"After incrimenting: {z}");
                z++;
                WriteLine($"After incrimenting: {z}");
                z++;
                WriteLine($"After incrimenting: {z}");
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I cought the exception.");
            }

            #endregion
        }
        
    }
}
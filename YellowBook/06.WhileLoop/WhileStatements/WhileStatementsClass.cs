
using System;
using System.Collections;
using System.Threading;
using static System.Console;


namespace WhileStatements
{
    public class WhileStatementsClass
    {
        // ---------------------------------------------------------------------
        
        public void DropTeaTemperature()
        {
            var temperature = 100;
            var newList = new ArrayList();

            while (temperature > 90)
            {
                temperature--;
                newList.Add(temperature);
            }

            WriteLine(string.Join('>', newList.ToArray()));
            WriteLine("The tea is cool enough.");
        }

        // ---------------------------------------------------------------------

        public void ExplosiveTimer()
        {
            int time = 10;

            WriteLine("Timer Start :");
            while (time > 0)
            {
                WriteLine($"{time}");
                time--;
                Thread.Sleep(500);
            
            }
            WriteLine("Blastoff!!!");
        }

        // ---------------------------------------------------------------------

        public long SumtoN(long n)
        {
            return (long)n*(n+1)/2;     // Gauss
        }

        public void SumToNSecond(long n)
        {
            long i, sum = 0;
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            WriteLine($"Sum of N numbers : {sum}");
        }

        // ---------------------------------------------------------------------

        public void OneChrPerLine(string text)
        {
            var i = 0;
            while (i < text.Length)
            {
                WriteLine(text[i]);
                i++;
            }
        }

        // ---------------------------------------------------------------------

        public void PrintVovels(string text)
        {
            var counter = 0;
            var vowels = "aoeui";

            WriteLine($"Text : {text}");
            Write("Vowels : ");
            while (counter < text.Length)
            {
                if (vowels.Contains(text[counter].ToString().ToLower()))
                {
                    if (counter == text.Length - 2)
                    {
                        Write(text[counter]);
                        WriteLine();
                    }
                    else
                    {
                        Write($"{text[counter]} - ");                        
                    }
                }
                counter++;
            }
        }

        // ---------------------------------------------------------------------
        
    }
}
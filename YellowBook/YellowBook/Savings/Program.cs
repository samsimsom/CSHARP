using System;
using static System.Console;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("-- Save Your Money! --");

            Write("Enter your money : ");
            decimal money = decimal.Parse(ReadLine());
            WriteLine(money);

            var counter = 1;
            while ( counter <= 3)
            {   
                WriteLine($"Year {counter} : {money *= 1.04m:C}");
                counter++;
            }
        }
        
    }
}

using System;
using HelpersLibrary;

namespace MethodConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers helper = new Helpers();
            
            while (true)
            {
                Console.Clear();
                helper.Title("Method Console App");
                helper.Seperator('/');
                Console.WriteLine();
                
                int selection;
                try
                {
                    Console.Write("Select : (1 to 8) > ");
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    break;
                }

                switch (selection)
                {
                    case 1:
                        var mathClass = new MathClass();
                        mathClass.MathMethod();
                        Console.ReadLine();
                        break;
                    case 2:
                        var maximumFinder = new MaximumFinder();
                        maximumFinder.MaximumFinderCalculate();
                        Console.ReadLine();
                        break;
                    case 3:
                        var rollDice = new RollDice();
                        rollDice.RollingDice();
                        Console.ReadLine();
                        break;
                    case 4:
                        var craps = new CrapsGame();
                        craps.Game();
                        Console.ReadLine();
                        break;
                    case 5:
                        var coinToss = new CoinToss();
                        coinToss.CoinFlip();
                        break;
                    case 6:
                        var scope = new Scope();
                        scope.MyMethod();
                        break;
                    case 7:
                        var myMath = new MyMath();
                        Console.Write("Enter a Number : ");
                        var userInput = Console.ReadLine();

                        int UserInputInt;
                        double UserInputDouble;
                        
                        if (Int32.TryParse(userInput, out UserInputInt))
                        {
                            Console.WriteLine(myMath.Square(UserInputInt));
                        }
                        else if (Double.TryParse(userInput, out UserInputDouble))
                        {
                            Console.WriteLine(myMath.Square(UserInputDouble));
                        }
                        else
                        {

                            Console.WriteLine($"Error!");
                        }

                        helper.ConsoleStoper();
                        break;
                    case 8:
                        var rm = new RecursiveMethod();
                        rm.MyMethod("Develi");
                        helper.ConsoleStoper();
                        break;
                }
            }
            
        }
    }
}
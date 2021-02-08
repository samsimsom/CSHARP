using System;

namespace MethodConsoleApp
{
    public class CrapsGame
    {
        private Random randomNumbers = new Random();
        
        private enum Status
        {
            Continue,
            Won,
            Lost
        }
        
        private enum DiceNames
        {
            SnakeEyes = 2,
            Trey = 3,
            Seven = 7,      // Win
            YoLeven = 11,   // win
            BoxCars = 12
        }

        public void Game()
        {
            int sumOfDice = CrapRollDice();
            int myPoint = 0;
            Status gameStatus = Status.Continue;


            switch ((DiceNames) sumOfDice)
            {
                case DiceNames.Seven:
                    case DiceNames.YoLeven:
                    gameStatus = Status.Won;
                    break;
                case DiceNames.SnakeEyes:
                    case DiceNames.Trey:
                    case DiceNames.BoxCars:
                    gameStatus = Status.Lost;
                    break;
                default:
                    gameStatus = Status.Continue;
                    myPoint = sumOfDice;
                    Console.WriteLine($"Point is {myPoint}");
                    break;
            }

            while (gameStatus == Status.Continue)
            {

                sumOfDice = CrapRollDice();
                
                if (sumOfDice == myPoint)
                {
                    gameStatus = Status.Won;

                }
                else
                {
                    if (sumOfDice == (int) DiceNames.Seven)
                    {
                        gameStatus = Status.Lost;
                    }
                }
            }

            Console.WriteLine(gameStatus == Status.Won ?
                "Player Wins!" : "Player Lose");
        }

        private int CrapRollDice()
        {
            int dice1 = randomNumbers.Next(1, 7);
            int dice2 = randomNumbers.Next(1, 7);

            int sum = dice1 + dice2;

            Console.WriteLine($"Player rolled {dice1} + {dice2} = {sum}");
            return sum;
        }
    }
}
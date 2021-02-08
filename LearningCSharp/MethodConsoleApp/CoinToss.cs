using System;

namespace MethodConsoleApp
{
    public class CoinToss
    {
        public void CoinFlip()
        {
            var choices = new[] {"Heads", "Tails"};
            var rnd = new Random();
            bool playerWon;
            var attempts = 0;
            
            do
            {
                attempts++;
                var computersToss = rnd.Next(0, 2);
                Console.WriteLine("Choose: Heads or Tails");
                playerWon = Console.ReadLine() == choices[computersToss];
                if (!playerWon)
                {
                    Console.WriteLine($"OFF! The coin landed on " +
                                      $"{choices[computersToss]}. Better Luck" +
                                      $" next time.");
                }
            } while (playerWon == false);

            Console.WriteLine($"Congratulations! You have chosen the " +
                              $"same result as the coin toss in {attempts}" +
                              $" attempts!");
            Console.Write("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
using System;
using System.Threading;
using static System.Console;

namespace RandomNumberGame
{
    public class RandomNumberGame
    {
        private const int MaxPlayerLife = 5;
        private int _playerLife = MaxPlayerLife;
        
        private int _userInput;
        private int _randomNumber;
        private int _rndNumRangeX = 1, _rndNumRangeY = 5;
        
        // -------------------------------------------------------------------------------
        // Visual Helpers!
        
        /// <summary>
        /// Ekrana bos bir satir eklemek icin kullanilir.
        /// </summary>
        public void EmptyLine()
        {
            WriteLine("");
        }

        /// <summary>
        /// Ekrana sirali tireler yazdirmka icin kullanilir.
        /// </summary>
        public void DottedLine()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(new String('-', 60));
            ResetColor();
        }

        /// <summary>
        /// Metinleri renkli olrak consola yazdirmak icin kullanilir.
        /// </summary>
        /// <param name="color">ConsoleColo.Red</param>
        /// <param name="text">String</param>
        /// <param name="mode">WriteLine:0 | Write:1 | Default:0</param>
        public void ColorfullText(ConsoleColor color, string text, int mode = 0)
        {
            ForegroundColor = color;
            switch (mode)
            {
                case 0:
                    WriteLine($"{text}");
                    break;
                case 1:
                    Write($"{text}");
                    break;
            }
            ResetColor();
        }
        // -------------------------------------------------------------------------------
        private void GetUserInput()
        {
            while (true)
            {
                ColorfullText(ConsoleColor.Gray, "Your Guess >> ", 1);
                var input = ReadLine();

                if (int.TryParse(input, out _userInput))
                {
                    if (_userInput < _rndNumRangeX || _userInput > _rndNumRangeY)
                    {
                        EmptyLine();
                        ColorfullText(ConsoleColor.Red, 
                            $"Tahminlerini {_rndNumRangeX} ile {_rndNumRangeY - 1 } " +
                            $"arasinda tahmin yaparsan sevinirim!");
                        EmptyLine();
                    }
                    else
                    {
                        _playerLife -= 1;
                        break;
                    }
                }
                else
                {
                    EmptyLine();
                    ColorfullText(ConsoleColor.Red, "RAKAM tahmin etmen gerekiyor!");
                    EmptyLine();
                }
            }
        }
        // -------------------------------------------------------------------------------
        private void PickRandomNumber()
        {
            _randomNumber = new Random().Next(_rndNumRangeX, _rndNumRangeY);
        }
        // -------------------------------------------------------------------------------
        private void StartScreen()
        {
            EmptyLine();
            ColorfullText(ConsoleColor.Blue, $"Aklimda bir sayi var {_rndNumRangeX} " +
                                             $"ile {_rndNumRangeY - 1} arasinda.");
            ColorfullText(ConsoleColor.Blue, "Tuttugum sayiyi tahmenin edebilir misin ?");
            EmptyLine();
        }
        // -------------------------------------------------------------------------------
        private void PlayerLifeDisplay()
        {
            if (_playerLife < MaxPlayerLife)
            {
                ColorfullText(ConsoleColor.Red, 
                    $"Tahmin hakkin {_playerLife} tane kaldi!");
                EmptyLine();
            }
        }
        // -------------------------------------------------------------------------------
        private void PlayAgain()
        {
            while (true)
            {
                EmptyLine();
                WriteLine("Tekrar Oynamak istermisin [y/n]");
                Write(">>> ");
                var input = ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.Y:
                        Clear();
                        _playerLife = MaxPlayerLife;
                        Game();
                        break;

                    case ConsoleKey.N:
                        Clear();
                        var goodByeText = "Hoscakal!";
                        WriteLine(goodByeText);

                        var spinner = new Spinner(goodByeText.Length + 1 , 0);
                        spinner.Start();
                        Thread.Sleep(3000);
                        spinner.Stop();
                        
                        Environment.Exit(0);
                        break;

                    default:
                        Clear();
                        DottedLine();
                        EmptyLine();
                        ColorfullText(ConsoleColor.Yellow, 
                            "Oynamak istiyor musun?(y), istemiyor musun?(n)!");
                        EmptyLine();
                        DottedLine();
                        continue;
                }

                break;
            }
        }

        // -------------------------------------------------------------------------------
        private void WinLogic()
        {
            if (_playerLife >= 1 && _userInput != _randomNumber)
            {
                StartScreen();
            }
            else if (_userInput == _randomNumber)
            {
                Clear();
                DottedLine();
                EmptyLine();
                WriteLine("Kazandin!");
                EmptyLine();
                DottedLine();
                PlayAgain();
            }
            else
            {
                Clear();
                DottedLine();
                EmptyLine();
                WriteLine($"Kaybettin! Tuttgum sayi : {_randomNumber}");
                EmptyLine();
                DottedLine();
                
                PlayAgain();
            }
        }
        // -------------------------------------------------------------------------------
        public void Game()
        {
            // TODO: Game Loop u yeniden duzenlemelisin.
            // TODO: Deneme. Multiline TODO olayini cozemedim.
            
            StartScreen();
            PickRandomNumber();

            while (true)
            {
                PlayerLifeDisplay();
                GetUserInput();
                Clear();
                WinLogic();
            }
            // TODO: Burada bir warning cikiyor onunda sirrini henuz anlayamadim!
            // ReSharper disable once FunctionNeverReturns
        }
        // -------------------------------------------------------------------------------
    }
}
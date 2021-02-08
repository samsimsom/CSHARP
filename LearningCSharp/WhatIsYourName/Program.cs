using System;

namespace WhatIsYourName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person1 = new Name("Deve", 12);
            var person2 = new Name("Kamil", 35);

            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(6);
                Console.WriteLine($"Random Number is {randomNumber}");
                
                switch (randomNumber)
                {
                    case 1:
                        person1.SayHello();
                        person1.Attac();
                        break;
                    case 2:
                        person2.Attac();
                        break;
                    case 3:
                        person2.SayHello();
                        break;
                    case 4:
                    case 5: 
                        person1.Attac();
                        person2.Attac();
                        break;
                    default:
                        Console.WriteLine("Nothing!");
                        break;
                }
            }
        }
    }
}
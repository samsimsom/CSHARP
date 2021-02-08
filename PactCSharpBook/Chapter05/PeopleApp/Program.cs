
using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("-- People App --");

            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1956, 8, 24);
            
            WriteLine($"{bob.Name} was born on " +
                      $"{bob.DateOfBirth:dddd, d MMMM yyyy}");

            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
            
            WriteLine($"{bob.Name} is a {Person.Species}");
            
            bob.Children.Add(new Person {Name = "Alfred"});
            bob.Children.Add(new Person {Name = "Jessica"});

            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"{bob.Children[child].Name} is Bob's Child.");
            }
            

            BankAccount.InterestRate = 0.012M;          // Store a shared value

            var alfredAccount = new BankAccount();      // Instance BankAccount
            alfredAccount.AccountName = "Mrs. Alfred";
            alfredAccount.Balance = 2400;

            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: alfredAccount.AccountName,
                arg1: alfredAccount.Balance * BankAccount.InterestRate);

            var jessicaAccount = new BankAccount();     // Instance BankAccount
            jessicaAccount.AccountName = "Ms. Jessica";
            jessicaAccount.Balance = 5600;

            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: jessicaAccount.AccountName,
                arg1: jessicaAccount.Balance * BankAccount.InterestRate);


        }
    }
}
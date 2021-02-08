
using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    public class TextAndNumber
    {
        public string Text;
        public int Number;
    }

    public class Processor
    {
        public TextAndNumber GetTheData()
        {
            return new TextAndNumber
            {
                Text = "What's the meaning of life?",
                Number = 42
            };
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            
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


            // Blank Person for Constructor
            var blankPerson = new Person();
            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} " +
                              "on a {2:dddd}.",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated);

            var gunny = new Person("Gunny", "Mars");
            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} " +
                              "on a {2:dddd}.",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated);
            
            // Defauls
            var thingOfDefault = new ThingOfDefaults();
            WriteLine("Default Values");
            WriteLine($"{thingOfDefault.Population} - {thingOfDefault.When} - " +
                      $"{thingOfDefault.Name} - {thingOfDefault.People}");
            
            
            // METHOD CALL
            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());
            
            WriteLine(new string('-', 35));
            
            // Return Value
            var toReturn = new Processor();
            var result = toReturn.GetTheData();
            WriteLine(result.Text);
            WriteLine(result.Number);
            
            WriteLine(new string('-', 35));

            (string, int) fruit = bob.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
            
            WriteLine(new string('-', 35));

            var thing1 = ("Neville", 4);
            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"ThingOne = {thing1.Item1} has {thing1.Item2} children.");
            WriteLine($"ThingTwo = {thing2.Name} has {thing2.Count} children.");
            
            WriteLine(new string('-', 35));

            (string name, int age) deconstruct = bob.GetPerson();
            WriteLine($"{deconstruct.name} is {deconstruct.age} yeas old!");
        }
    }
}
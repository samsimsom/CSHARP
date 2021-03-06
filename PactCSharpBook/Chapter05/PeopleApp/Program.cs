﻿
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

            WriteLine(new string('-', 35));
            WriteLine(bob.SayHello("Deve"));
            WriteLine(bob.SayHelloTo("Firat"));
            WriteLine(gunny.DirtyTalk("Zombi"));
            WriteLine(gunny.SaySomething("Blah Blash!"));

            WriteLine();

            WriteLine(new string('-', 35));
            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");
            
            WriteLine();

            WriteLine(new string('-', 35));
            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            
            sam.FavoriteIceCream = "Chocolate Fudge";
            sam.FavoritePrimaryColor = "Red";

            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");
            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine($"Sam {sam.Age} yeas old!");
            
            WriteLine();

            WriteLine(new string('-', 35));
            sam.Children.Add(new Person { Name = "Charlie" });
            sam.Children.Add(new Person { Name = "Ella" });

            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");

            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");

            WriteLine();

            WriteLine(new string('-', 35));
            // -----------------------------------------------------------------
            object[] passengers = {
                new FirstClassPassenger { AirMiles = 1_419 },
                new FirstClassPassenger { AirMiles = 12_234 },
                new BusinessClassPassenger(),
                new CoachClassPassenger { CarryOnKG = 25.7 },
                new CoachClassPassenger { CarryOnKG = 0 },
            };

            // C# 8
            foreach (object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    FirstClassPassenger p when p.AirMiles > 3500    => 1500M,
                    FirstClassPassenger p when p.AirMiles > 1500    => 1750M,
                    FirstClassPassenger _                           => 2000M,
                    BusinessClassPassenger _                        => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0   => 500m,
                    CoachClassPassenger _                           => 650M,
                    _                                               => 800M

                };

                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }

            WriteLine();
            
            // C# 9
            foreach (object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 3500 => 1500M,
                        > 1500 => 1750M,
                        _      => 2000M
                    },

                    BusinessClassPassenger _                        => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0   => 500m,
                    CoachClassPassenger _                           => 650M,
                    _                                               => 800M
                };

                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }
            // -----------------------------------------------------------------
            WriteLine();

            var jeff = new ImmutablePerson
            {
                FirstName = "Jeff",
                LastName = "Peterson"
            };

            // jeff.FirstName = "Geoff"; // init-only

            WriteLine(new string('-', 35));
            WriteLine();

            var car = new ImmutableVehicle
            {
                Brand = "Mazda MX-5 RF",
                Color = "Soul Red Crystal Metalic",
                Wheels = 4
            };

            var repaintedCar = car with { Color = "Polymetal Grey Metallic" };

            WriteLine("Orginal color war {0}, new color is {1}.",
            arg0: car.Color, arg1: repaintedCar.Color);

            WriteLine();

            WriteLine(new string('-', 35));
            
            var oscar = new ImmutableAnimal("Oscar", "Labrador");
            var (who, what) = oscar;
            WriteLine($"{who} is a {what}.");
            
            WriteLine();
        }
    }
}
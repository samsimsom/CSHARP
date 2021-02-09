
using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : object
    {
        // FIELD & PROPERTY
        // ---------------------------------------------------------------------
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";                // Constant
        public readonly string HomePlanet = "Earth";                // read-only
        public readonly DateTime Instantiated;
        // ---------------------------------------------------------------------


        // CONSTRTUCTOR
        // ---------------------------------------------------------------------
        public Person()
        {
            // set default value for fields
            // including read only fiels

            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }
        // ---------------------------------------------------------------------


        // METHOD
        // ---------------------------------------------------------------------
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string name, int age) GetPerson()
        {
            return (Name, DateTime.Now.Year - DateOfBirth.Year);
        }

        public string SayHello()
        {
            return $"{Name}'s says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"Hello {name}";
        }

        public string SayHelloTo(string name)
        {
            return $"{Name}'s says 'Hello {name}!'";
        }

        public string DirtyTalk(string name)
        {
            return $"{Name}'s says 'go fuck your self! {name}";
        }

        // ---------------------------------------------------------------------


    }
}
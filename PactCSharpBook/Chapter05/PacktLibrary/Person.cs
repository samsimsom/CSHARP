
using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        // Fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        
        // Constant
        public const string Species = "Homo Sapien";
        
        // read-only
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        public Person()             // constructors
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
        
        // METHODS
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
        
    }
}

using System;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person
    {
        // a property defined using c# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties defined using c# 6+ lambda expression syntax
        public string Greeting => $"{Name} says Hello!";
    
        public int Age => DateTime.Today.Year - DateOfBirth.Year;

    }
}
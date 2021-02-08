
using System;
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
    }
}
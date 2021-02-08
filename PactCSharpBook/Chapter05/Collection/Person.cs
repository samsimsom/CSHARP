
using System;
using System.Collections.Generic;

namespace Collection
{
    public class Person : Object
    {
        // Fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
    }
}
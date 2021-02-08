
using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingOfDefaults : object
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingOfDefaults()
        {
            Population = default(int);
            When = default(DateTime);
            Name = default(String);
            People = default(List<Person>);
        }
    }
}
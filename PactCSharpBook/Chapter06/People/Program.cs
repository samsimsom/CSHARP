using System;
using Packt.Shared;
using static System.Console;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            var harry = new Person() { Name = "Harry"};
            var mary = new Person() { Name = "Mary" };
            var jill = new Person() { Name = "Jill" };

            // Call instance method
            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";

            // Call static method
            var baby2 = Person.Procreate(harry, jill);

            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            WriteLine(format: "{0}'s first child is named \"{1}\".",
                      arg0: harry.Name,
                      arg1: harry.Children[0].Name);
            
            harry.DoSomethin();
            
        }
    }
}
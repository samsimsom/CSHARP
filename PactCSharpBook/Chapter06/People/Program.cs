using System;
using Packt.Shared;
using static System.Console;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            var harry = new Person() { Name = "Harry"};
            var mary = new Person() { Name = "Mary" };
            var jill = new Person() { Name = "Jill" };

            // Call instance method
            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";

            // Call static method
            var baby2 = Person.Procreate(harry, jill);
            
            // call an operator
            var baby3 = harry * mary;
            
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            WriteLine(format: "{0}'s first child is named \"{1}\".",
                      arg0: harry.Name,
                      arg1: harry.Children[0].Name);
            
            
            // local function Recursive call
            WriteLine($"5! is {Person.Factorial(5)}");
            
            // Delegate
            WriteLine(harry.MethodIWantToCall("EkmekPeynir"));
            var d = new Person.DelegateWithMatchingSignature(harry.MethodIWantToCall);
            var answer2 = d("Ekmek");
            WriteLine(answer2);

            harry.Shout = Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            // TESTS
            harry.DoSomethin();
            
        }
        
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}
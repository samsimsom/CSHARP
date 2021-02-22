using System;
using System.Xml;
using Packt.Shared;
using static System.Console;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            var harry = new Person() {Name = "Harry"};
            var mary = new Person() {Name = "Mary"};
            var jill = new Person() {Name = "Jill"};

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

            // seperator
            WriteLine(new string('-', 35));

            // Comparing object when sorting
            Person[] people =
            {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam"},
                new Person {Name = "Richard"},
                new Person {Name = "Ayse"},
                new Person {Name = "Ahmet"},
                new Person {Name = "Zekeriya"}
            };

            WriteLine("Initial List Of People : ");
            foreach (var person in people)
            {
                WriteLine($"    {person.Name}");
            }

            WriteLine("Use Person's IComparable implemantation to sort : ");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"    {person.Name}");
            }

            // -----------------------------------------------------------------
            // seperator
            WriteLine(new string('-', 35));

            WriteLine("Use PersonComparer's IComparer implementation to sort : ");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"    {person.Name}");
            }
            // -----------------------------------------------------------------

            // Object
            // -----------------------------------------------------------------
            // seperator
            WriteLine(new string('-', 35));

            var t1 = new Thing();
            t1.Data = 42;
            WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            WriteLine($"Thing with a string: {t2.Process("apple")}");
            // -----------------------------------------------------------------
            
            // Generic Type
            // -----------------------------------------------------------------
            // seperator
            WriteLine(new string('-', 35));
            
            var g1 = new GenericThing<int>();
            g1.Data = 42;
            WriteLine($"GenericThing with an integer: {g1.Process(42)}");
            
            var g2 = new GenericThing<string>();
            g2.Data = "apple";
            WriteLine($"GenericThing with a string: {g2.Process("apple")}");
            
            var g3 = new GenericThing<char>();
            g3.Data = 'A';
            WriteLine($"GenericThing with a char: {g3.Process('A')}");
            
            WriteLine(new string('-', 35));
            // -----------------------------------------------------------------
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            var p = (Person) sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }

        //----------------------------------------------------------------------
    }
}
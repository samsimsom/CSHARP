
using System;
using static System.Console;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            person1.Name = "Bob";
            person1.DateOfBirth = new DateTime(1984, 12, 15);
            
            person1.Children.Add(new Person { Name="Alfred" });
            person1.Children.Add(new Person { Name="Jessica" });
            
            WriteLine($"{person1.Name} was born on " +
                      $"{person1.DateOfBirth:dddd, d, MMMM, yyyy}");
            WriteLine($"{person1.Name} has {person1.Children.Count} children.");
            WriteLine($"{person1.Name}'s childrens names are :");
            foreach (var children in person1.Children)
            {
                Write($"{children.Name} ");
            }

        }
    }
}
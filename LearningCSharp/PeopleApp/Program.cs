
using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            person1.Name = "Samsi";
            person1.DateOfBirth = new DateTime(1984,12,15);
            // person1.Favorite = WondersOfTheAncietWorld.Ephesus;
            person1.Bucketlist = WondersOfTheAncietWorld.Babylon | 
                                 WondersOfTheAncietWorld.Babylon;
            
            WriteLine($"{person1.Name} was born on " +
                      $"{person1.DateOfBirth:dddd, d MMMM yyyy}, \n" +
                      $"{person1.Name}'s faworite wonder is {person1.Bucketlist}.");
            
        }
    }
}
using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person
    {
        // FIELDS
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        
        // METHODS
        public void WriteConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth}");
        }

        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
        
        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }
        
        // method with a local function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                var eMessage = $"{nameof(number)} cannot be less than zero.";
                throw new ArgumentException(eMessage);
            }

            return localFactorial(number);

            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                {
                    return localNumber * localFactorial(localNumber - 1);
                }
            }
        }

        public void DoSomethin()
        {
            var rndNnumber = new Random().Next(1, 6);
            Write("Do Something : ");
            switch (rndNnumber)
            {
                case 1:
                    WriteLine($"{rndNnumber}");
                    break;
                case 2:
                    WriteLine($"{rndNnumber}");
                    break;
                case 3:
                    WriteLine($"{rndNnumber}");
                    break;
                case 4:
                    WriteLine($"{rndNnumber}");
                    break;
                case 5:
                    WriteLine($"{rndNnumber}");
                    break;
            }
        }

    }
}
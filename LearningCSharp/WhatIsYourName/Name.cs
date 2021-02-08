using System;

namespace WhatIsYourName
{
    public class Name
    {
        public string UserName { get; set; }
        public int Age { get; set; }

        public Name(string name, int age)
        {
            this.UserName = name;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hi my name is {UserName}, " +
                              $"I'm {Age} years old!");
        }

        public void Attac()
        {
            Console.WriteLine($"Fuck you {UserName}!");
        }
    }
}
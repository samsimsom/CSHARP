using System;
using static System.Console;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Boolean Operators!");
            WriteLine(new string('-', 35));

            var a = true;
            var b = false;
            
            WriteLine($"a is {a} - b is {b}");
            WriteLine($"AND | a     | b ");
            WriteLine($"a   | {a} & {a} = {a & a, -5} " +
                      $"| {a} & {b} = {a & b, -5} ");
            WriteLine($"b   | {b} & {a} = {b & a, -5} " +
                      $"| {b} & {b} = {b & b, -5} ");
            
            WriteLine();
            
            WriteLine($"OR  | a     | b ");
            WriteLine($"a   | {a} | {a} = {a | a, -5} " +
                      $"| {a} | {b} = {a | b, -5} ");
            WriteLine($"b   | {b} | {a} = {b | a, -5} " +
                      $"| {b} | {b} = {b | b, -5} ");
            
            WriteLine();
            
            WriteLine($"XOR | a     | b ");
            WriteLine($"a   | {a} ^ {a} = {a ^ a, -5} " +
                      $"| {a} ^ {b} = {a ^ b, -5} ");
            WriteLine($"b   | {b} ^ {a} = {b ^ a, -5} " +
                      $"| {b} ^ {b} = {b ^ b, -5} ");
            
            WriteLine(new string('-', 35));
            
            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");
            
            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");
            
        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
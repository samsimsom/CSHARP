using System;
using HelpersLibrary;

namespace MethodConsoleApp
{
    public class Scope
    {
        private Helpers helpers = new Helpers();
        
        private static int x = 1;

        public void MyMethod()
        {
            var x = 5;
            Console.WriteLine($"local x in method MyMethod {x}");

            UseStaticVariable();
            UseLocalVariable();

            UseStaticVariable();
            UseLocalVariable();

            Console.WriteLine($"\nLocal x in method MyMethod {x}");
            helpers.ConsoleStoper();
        }

        private void UseLocalVariable()
        {
            var x = 25;
            Console.WriteLine($"\nlocal x on entering method " +
                              $"UseLocalVariable is {x}");
            ++x; // modifies this method's local variable x
            Console.WriteLine($"local x before exiting method " +
                              $"UseLocalVariable is {x}");
        }

        private void UseStaticVariable()
        {
            Console.WriteLine($"\nstatic variable x on entering method " +
                              $"UseStaticVariable is {x}");
            x *= 10; // modifies class Scope's static variable x.
            Console.WriteLine("static variable x before exiting " +
                              $"method UseStaticVariable is {x}");
        }
    }
}
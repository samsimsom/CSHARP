using System;
using HelpersLibrary;

namespace HandlingExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Helpers();
            helper.ConsoleCleaner();
            helper.Title("Converting!");

            var converting = new Converting();
            // converting.ConvertingExampleOne();
            // converting.ConvertingExampleTwo();
            // converting.ConvertingExampleThree();
            // converting.ConvertingExampleFour();
            // converting.HandlingExeptionOne();
            // converting.HandlingExeptionTwo();
            // converting.HandlingExeptionThree();
            
        }

    }
}
using System;
using HelpersLibrary;

namespace SwitchExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Helpers
            var helpers = new Helpers();
            helpers.Title("Switch Examples!");

            var switchClass = new SwitchClass();
            // switchClass.SwitchExampleOne();
            // switchClass.SwitchExampleTwo();
            switchClass.SwitchExampleTree();
        }
    }
}
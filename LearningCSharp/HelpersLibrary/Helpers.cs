using System;
using static System.Console;

namespace HelpersLibrary
{
    public class Helpers
    {
        /// <summary>
        /// Dotted Line Seperator Method
        /// </summary>
        /// <param name="chr">Dottet Visual Representation</param>
        /// <param name="count">Repeat Count</param>
        public void Seperator(char chr, int count=30)
        {
            var seperator = new string(chr, count);
            WriteLine(seperator);
        }
        
        //----------------------------------------------------------------------
        /// <summary>
        /// Console Title Menu Creator
        /// </summary>
        /// <param name="text">string Title</param>
        /// <param name="count">int Frame Legnht</param>
        public void Title(string text, int count=30)
        {
            Seperator('-', count);
            var emtySpace = Math.Abs(count - text.Length) / 2;
            var newText = new string(' ', emtySpace) + text;
            Colorize(ConsoleColor.Red, newText);
            Seperator('-', count);
        }
        
        //----------------------------------------------------------------------
        /// <summary>
        /// Text Colorizer
        /// </summary>
        /// <param name="clr">ConsoleColor</param>
        /// <param name="text">string Text</param>
        public void Colorize(ConsoleColor clr, string text)
        {
            ForegroundColor = clr;
            WriteLine(text);
            ResetColor();
        }

        //----------------------------------------------------------------------
        /// <summary>
        /// Wait for user input
        /// </summary>
        /// <param name="chr">char frame symbol</param>
        /// <param name="count">int frame lenght</param>
        public void ConsoleStoper(char chr='-', int count=30)
        {
            WriteLine();
            Seperator(chr, count);
            WriteLine("press any key to exit...");
            ReadKey(true);
        }
        
        //----------------------------------------------------------------------
        /// <summary>
        /// Clear Console
        /// </summary>
        public void ConsoleCleaner()
        {
            Clear();
        }
    }
}
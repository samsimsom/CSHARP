
using System;
using System.IO;
using static System.Console;

namespace SwitchExamples
{
    public class SwitchClass
    {
        //----------------------------------------------------------------------

        public void SwitchExampleOne()
        {
            A_Label:
            var number = new Random().Next(1, 7);
            
            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Tree of Four");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(1000);
                    goto A_Label;
                default:
                    WriteLine("default");
                    break;
            }
        }
        
        //----------------------------------------------------------------------

        public void SwitchExampleTwo()
        {
            var path = @"/home/samsimsom/Desktop";
            var fileName = "file.txt";
            
            Write("Press (R) for read-only or (W) for write: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();

            var s = Stream.Null;

            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(path, fileName),
                    FileMode.OpenOrCreate,
                    FileAccess.Read);
            }
            else
            {
                s = File.Open(
                    Path.Combine(path, fileName),
                    FileMode.OpenOrCreate,
                    FileAccess.Write);
            }

            var message = string.Empty;

            switch (s)      // pattern matching with switch statement.
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a readonly file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address.";
                    break;
                default:
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null.";
                    break;
            }
            
            WriteLine(message);
        }
        
        //----------------------------------------------------------------------

        public void SwitchExampleTree()
        {
            var path = @"/home/samsimsom/Desktop";
            var fileName = "file.txt";
            
            Write("Press (R) for read-only or (W) for write: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();

            var s = Stream.Null;

            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(path, fileName),
                    FileMode.OpenOrCreate,
                    FileAccess.Read);
            }
            else
            {
                s = File.Open(
                    Path.Combine(path, fileName),
                    FileMode.OpenOrCreate,
                    FileAccess.Write);
            }

            var message = string.Empty;

            message = s switch
            {
                FileStream writeableFile when s.CanWrite
                    => "The stream is a file that I can write to.",
                FileStream readOnlyFile 
                    => "The stream is a readonly file.",
                MemoryStream ms
                    => "The stream is a memory address.",
                null 
                    => "The stream is null.",
                _ 
                    => "The stream is some other type."
            };
            
            WriteLine(message);
            WriteLine($"Yani digeri daha guzel sanki");
        }

        private void Test()
        {
            Console.WriteLine($"");
        }
    }
}
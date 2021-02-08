using System;
using static System.Console;

namespace ConsoleArguments
{
    public class ArgumantClass
    {
        public void InputArgument(string[] args)
        {
            if (args.Length < 3)
            {
                WriteLine("You must specify two colors and cursor size, e.g.");
                WriteLine("dotnet run red yellow 50");
                return;
            }

            ForegroundColor = (ConsoleColor) Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true);

            BackgroundColor = (ConsoleColor) Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true);

            try
            {
                CursorSize = int.Parse(args[2]);
            }
            catch (PlatformNotSupportedException)
            {
                WriteLine("Cursor size can not change in this platform!");
            }
        }
    }
}
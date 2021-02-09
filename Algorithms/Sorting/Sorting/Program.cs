
using Helper;
using static System.Console;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Visual();
            
            helper.CleanScreen();
            WriteLine("-- Sorting Algorithms --");
            helper.LineSeperator();
            
            // TODO: Make it random int generator.
            int[] data = new[]
            {
                1, 23, 44, 22, 76, 49, 85, 34, 2, 4, 8, 323, 68, 43, 795, 34,
                35, 80, 67, 751, 57, 37, 96, 198, 5, 7, 36, 97, 63, 77, 59, 14
            };

            var bubble = new Bubble();
            bubble.BubbleSort(data);
            helper.LineSeperator();

            var builtinShort = new BuiltIn();
            builtinShort.BuiltInSort(data);
            helper.LineSeperator();
        }
    }
}
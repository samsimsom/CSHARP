
using static System.Console;

namespace WhileLoop
{
    public class ANDaOR
    {
        public void ShortCircuiting()
        {
            int x = 5;
            int y = 2;
            int z = 1;

            WriteLine(y/x > z && x != 0);       // false

            x = 2;
            y = 5;
            WriteLine(y/x > z && x != 0);       // true

        }
    }
}
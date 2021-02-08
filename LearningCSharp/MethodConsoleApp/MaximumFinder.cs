using static System.Console;

namespace MethodConsoleApp
{
    public class MaximumFinder
    {
        public void MaximumFinderCalculate()
        {
            WriteLine("Enter first floating-point value: ");
            double numbe1 = double.Parse(ReadLine());

            WriteLine("Enter second floating-point value: ");
            double numbe2 = double.Parse(ReadLine());

            WriteLine("Enter third floating-point value: ");
            double number3 = double.Parse(ReadLine());


            double result = Maximum(numbe1, numbe2, number3);

            WriteLine($"Maximum is {result}");
        }

        private double Maximum(double x, double y, double z)
        {
            double maximumValue = x;

            if (y > maximumValue)
            {
                maximumValue = y;
            }

            if (z > maximumValue)
            {
                maximumValue = z;
            }
            
            return maximumValue;
        }
    }
}
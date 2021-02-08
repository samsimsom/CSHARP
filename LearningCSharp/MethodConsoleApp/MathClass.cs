using System;

namespace MethodConsoleApp
{
    public class MathClass
    {
        public void MathMethod()
        {
            int number1 = -12;
            // Abs verilen sayisal degerin tipi ne olursa olsun
            // absolute degerini verir pozitif sayi.
            int absNumber1 = Math.Abs(number1);
            Console.WriteLine(absNumber1);

            Console.WriteLine(new string('-', 45));
            
            double number2 = 23.13;
            // Ceiling ve Floor deicam ve double tipleri ile calisir,
            // Ceiling yukari yuvarlar, (tavan) tipini degistirmez.
            // Floor assagi yuvarlar. (zemin) tipini degistirmz.
            double ceilingNumber2 = Math.Ceiling(number2);
            double floorNumber2 = Math.Floor(number2);
            Console.WriteLine($"Value: {number2} - Ceiling: {ceilingNumber2}" +
                              $" - Floor: {floorNumber2}");
            
            Console.WriteLine(new string('-', 45));

            var coss = Math.Cos(12.2);
            var sinn = Math.Sin(12.2);
            var tann = Math.Tan(12.2);

            Console.WriteLine($"Cos: {coss} / Sin: {sinn} / Tan: {tann}");
            
            Console.WriteLine(new string('-', 45));

            

        }
    }
}
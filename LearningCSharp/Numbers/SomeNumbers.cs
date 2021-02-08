using static System.Console;

namespace Numbers
{
    public class SomeNumbers
    {
        public void NumberExampleOne()
        {
            // unsigned integers - positive whole numbers.
            // including 0
            uint naturalNumbers = 23;
            
            // integer - positive or negative whole numbers.
            // including 0
            int integerNumber = -23;
            
            // float - single-precision floating point.
            // F or f suffix makes it a float literal.
            float realNumber = 23.2f;
            
            // double - double-precision floating point.
            double anotherRealNumber = 23.42; // double literal.

            // Write to Console
            
            WriteLine($"Unsigned (uint) : {naturalNumbers}");
            WriteLine($"Integer (int) : {integerNumber}");
            WriteLine($"Float (float) : {realNumber}");
            WriteLine($"Double (double) : {anotherRealNumber}");
        }
        
        //----------------------------------------------------------------------
        
        public void NumberExampleTwo()
        {
            // three variables that store the number 2 million.
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            
            
            // check the tree variables have the same value
            WriteLine($"{decimalNotation == binaryNotation}");
            WriteLine($"{binaryNotation == hexadecimalNotation}");
            WriteLine($"{decimalNotation == hexadecimalNotation}");
        }
        
        //----------------------------------------------------------------------

        public void NumberExampleTree()
        {
            WriteLine(new string('_', 35));
            WriteLine($"sbyte uses {sizeof(sbyte)} bytes");
            WriteLine($"sbyte can store numbers in the range {sbyte.MinValue:N0} " +
                      $"to {sbyte.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"byte uses {sizeof(byte)} bytes");
            WriteLine($"byte can store numbers in the range {byte.MinValue:N0} " +
                      $"to {byte.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"short uses {sizeof(short)} bytes");
            WriteLine($"short can store numbers in the range {short.MinValue:N0} " +
                      $"to {short.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"ushort uses {sizeof(ushort)} bytes");
            WriteLine($"ushort can store numbers in the range {ushort.MinValue:N0} " +
                      $"to {ushort.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"int uses {sizeof(int)} bytes");
            WriteLine($"int can store numbers in the range {int.MinValue:N0} " +
                      $"to {int.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"uint uses {sizeof(uint)} bytes");
            WriteLine($"uint can store numbers in the range {uint.MinValue:N0} " +
                      $"to {uint.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"long uses {sizeof(long)} bytes");
            WriteLine($"long can store numbers in the range {long.MinValue:N0} " +
                      $"to {long.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"ulong uses {sizeof(ulong)} bytes");
            WriteLine($"ulong can store numbers in the range {ulong.MinValue:N0} " +
                      $"to {ulong.MaxValue:N0}");
            WriteLine(new string('_', 35));
            WriteLine($"float uses {sizeof(float)} bytes");
            WriteLine($"float can store numbers in the range {float.MinValue:G} " +
                      $"to {float.MaxValue:G}");
            WriteLine(new string('_', 35));
            WriteLine($"double uses {sizeof(double)} bytes");
            WriteLine($"double can store numbers in the range {double.MinValue:G} " +
                      $"to {double.MaxValue:G}");
            WriteLine(new string('_', 35));
            WriteLine($"decimal uses {sizeof(decimal)} bytes");
            WriteLine($"decimal can store numbers in the range {decimal.MinValue:N} " +
                      $"to {decimal.MaxValue:N}");
            WriteLine(new string('_', 35));
        }
        
        //----------------------------------------------------------------------

        public void DoubleComparisonOne()
        {
            WriteLine("Using doubles!");
            double a = 0.1;
            double b = 0.2;

            if (a == b)
            {
                WriteLine($"{a} + {b} equal {a + b}");
            }
            else
            {
                WriteLine($"{a} + {b} does NOT equal {a + b}");
            }
            
            // 0.1 + 0.2 does NOT equal 0.30000000000000004
        }
        
        //----------------------------------------------------------------------

        public void DecimalComparisonOne()
        {
            WriteLine("Using Decimal!");
            decimal a = 0.1m;
            decimal b = 0.2m;

            if (a == b)
            {
                WriteLine($"{a} + {b} equal {a + b}");
            }
            else
            {
                WriteLine($"{a} + {b} equal {a + b}");
            }
            // 0.1+0.2 equal 0.3
        }

        //----------------------------------------------------------------------

        public void ObjectType()
        {
            object height = 1.88;
            object name = "Firat";
            WriteLine($"{name} is {height} meters tall.");

            int lenght1 = ((string) name).Length;
            WriteLine(lenght1);
        }

        //----------------------------------------------------------------------

        
    }
}
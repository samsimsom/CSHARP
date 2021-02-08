using System;
using static System.Console;

namespace NumbersMinMax
{
    public class NumbersList
    {
        public void Numbers()
        {
            Clear();

            WriteLine(new string('-', 85));
            WriteLine(
                format: "{0, -10} {1, -10} {2, 20} {3, 35}",
                "Type",
                "Byte(s) of Memory",
                "Min",
                "Max");
            WriteLine(new string('-', 85));

            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "sbyte",
                sizeof(sbyte),
                sbyte.MinValue,
                sbyte.MaxValue);

            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "byte",
                sizeof(byte),
                byte.MinValue,
                byte.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "short",
                sizeof(short),
                short.MinValue,
                short.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "ushort",
                sizeof(ushort),
                ushort.MinValue,
                ushort.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "int",
                sizeof(int),
                int.MinValue,
                int.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "uint",
                sizeof(uint),
                uint.MinValue,
                uint.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "long",
                sizeof(long),
                long.MinValue,
                long.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "ulong",
                sizeof(ulong),
                ulong.MinValue,
                ulong.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "float",
                sizeof(float),
                float.MinValue,
                float.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -10} {2, 27} {3, 35}",
                "double",
                sizeof(double),
                double.MinValue,
                double.MaxValue);
            
            WriteLine(
                format: "{0, -10} {1, -7} {2, 27} {3, 35}",
                "decimal",
                sizeof(decimal),
                decimal.MinValue,
                decimal.MaxValue);
            
            WriteLine(new string('-', 85));
            WriteLine();

        }
    }
}
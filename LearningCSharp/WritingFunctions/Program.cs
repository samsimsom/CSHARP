using System;

namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeTable = new Functions();
            // timeTable.RunTimesTable();
            // timeTable.RunCalculateTax();
            // timeTable.RunCardinalToOrdinal();
            // timeTable.RunFactorial();
            // timeTable.RunFibImperative();
            timeTable.RunFibFunctional();
            
        }
    }
}
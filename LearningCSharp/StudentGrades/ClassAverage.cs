using System;

namespace StudentGrades
{
    public class ClassAverage
    {
        public void ClassAverageCalculate()
        {
            int total = 0;
            int gradeCounter = 1;

            while (gradeCounter <= 10)
            {
                Console.Write("Enter grade: ");
                int grade = int.Parse(Console.ReadLine() ?? string.Empty);
                total += grade;
                gradeCounter++;
            }

            int avarage = total / 10;

            Console.WriteLine($"\nTotal of all 10 grades is {total}");
            Console.WriteLine($"Classa varage is {avarage}");
        }
    }
}
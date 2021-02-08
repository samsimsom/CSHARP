using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Executables

            /*
            var student1 = new Student("Jane Green", 93);
            var student2 = new Student("Jhon Blue", 72);

            Console.WriteLine($"{student1.Name}'s letter grade equivalent of " +
                              $"{student1.Avarage} is {student1.LetterGrade}");

            Console.WriteLine($"{student2.Name}'s letter grade equivalent of " +
                              $"{student2.Avarage} is {student2.LetterGrade}");
            */

            /*
            ClassAverage classAvarage = new ClassAverage();
            classAvarage.ClassAverageCalculate();
            */

            /*
            ClassAvarage2 classAvarage2 = new ClassAvarage2();
            classAvarage2.CalculateAvarage();
            */

            #endregion
            
            var analysis = new Analysis();
                analysis.ClassAnalysis();
        }
    }
}
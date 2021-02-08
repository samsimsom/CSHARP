using System;

namespace StudentGrades
{
    public class ClassAvarage2
    {
        public void CalculateAvarage()
        {
            int total = 0;
            int gradeCounter = 0;
            
            Console.Write("Enter grade or -1 to quit: ");
            int grade = int.Parse(Console.ReadLine());

            while (grade != -1)
            {
                total += grade;
                gradeCounter++;
                
                Console.Write("Enter grade or -1 to quit: ");
                grade = int.Parse(Console.ReadLine());
            }

            if (gradeCounter != 0)
            {
                double avarage = (double) total / gradeCounter;

                Console.WriteLine($"\nTotal of the {gradeCounter} grades entered is " +
                                  $"{total}");
                Console.WriteLine($"Class avarage is {avarage:F}");
            }
            else
            {
                Console.WriteLine("No grades were entered!");
            }
        }
    }
}
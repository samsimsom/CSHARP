using System;

namespace StudentGrades
{
    public class Analysis
    {
        public void ClassAnalysis()
        {
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;

            while (studentCounter <= 10)
            {
                Console.Write("Enter the next exam result : ");
                int examResult = int.Parse(Console.ReadLine() ?? string.Empty);

                if (examResult >= 60)
                {
                    passes++;
                }
                else
                {
                    failures++;
                }

                studentCounter++;
            }

            Console.WriteLine($"Total {studentCounter - 1} exam entered!");
            Console.WriteLine($"{passes} students passed the exam!");
            Console.WriteLine($"{failures} students fail the exam!");

            if (passes > 6)
            {
                Console.WriteLine($"You are a grate teacher. Take it this " +
                                  $"bonnus!");
            }
        }
    }
}
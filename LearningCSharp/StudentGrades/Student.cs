namespace StudentGrades
{
    public class Student
    {
        public string Name { get; set; }
        private int _avarage;

        public Student(string studentName, int studentAvarage)
        {
            Name = studentName;
            Avarage = studentAvarage;
        }

        public int Avarage
        {
            get => _avarage;
            set
            {
                if (value > 0)
                {
                    if (value <= 100)
                    {
                        _avarage = value;
                    }
                }
            }
        }

        public string LetterGrade
        {
            get
            {
                string letterGrade;
                
                if (_avarage >= 90)
                {
                    letterGrade = "A";
                }
                else if (_avarage >= 80)
                {
                    letterGrade = "B";
                }
                else if (_avarage >= 70)
                {
                    letterGrade = "C";
                }
                else if (_avarage >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                return letterGrade;
            }
        }
    }
}
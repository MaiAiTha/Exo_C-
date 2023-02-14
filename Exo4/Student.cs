using System;
namespace Exo4
{
	public class Student
	{
		public String Fullname { get; set; } = "";
		public double AVGGrade { get; set; }
		public double NBCourses { get; set; }

		public Student()
		{
		}

        public Student(String Fullname, double AVGGrade, double NBCourses)
        {
			this.Fullname = Fullname;
			this.AVGGrade = AVGGrade;
			this.NBCourses = NBCourses;
        }

        delegate void AvgChanged(double average);

        AvgChanged avgChangedDelegate = new AvgChanged(RecordGrade);

        private static void RecordGrade(double average)
        {
			double AVGGrades = AVGGrade * NBCourses + ) / (NBCourses + 1);
        }


    }
}


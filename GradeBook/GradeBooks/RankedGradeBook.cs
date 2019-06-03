using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            double percent = .2;
            int numStudents = Students.Count;
            int minStudent = 5;
            double twentyPercent = numStudents * percent;
            if (numStudents>=minStudent)
            {
                if
                return char.Parse("F");
            }
            else
            {
                throw new System.InvalidOperationException("Not enough students, need at least "+minStudent+" students");
            }
            
        }

       
    }
}

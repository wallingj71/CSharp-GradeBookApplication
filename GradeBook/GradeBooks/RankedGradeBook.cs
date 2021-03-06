﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            double percent = 0.2;
            int numStudents = Students.Count;
            int minStudent = 5;
            int threshold = (int)Math.Ceiling(numStudents * percent);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            char gradeLetterReturn;
            if (numStudents>=minStudent)
            {
                if (grades[threshold - 1] <= averageGrade)
                {
                    gradeLetterReturn = 'A';
                }
                else if (grades[(threshold * 2) - 1] <= averageGrade)
                {
                    gradeLetterReturn = 'B';
                }
                else if (grades[(threshold * 3) - 1] <= averageGrade)
                {
                    gradeLetterReturn = 'C';
                }
                else if (grades[(threshold * 4) - 1] <= averageGrade)
                {
                    gradeLetterReturn = 'D';
                }
                else
                {
                    gradeLetterReturn = 'F';
                }
            }
            else
            {
                throw new InvalidOperationException("Not enough students, need at least "+minStudent+" students");
            }
            return gradeLetterReturn;

        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
           
        }
         
        


    }
}

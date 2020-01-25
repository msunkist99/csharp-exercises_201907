using System;
using System.Collections.Generic;
using System.Text;

namespace MK_School_Class6
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, 
                       int studentId,
                       int numberOfCredits, 
                       double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, 
                       int studentId)
                        : this(name, studentId, 0, 0)
                        // "this" will call the constructor that takes four input values
        {
        }

        public Student(string name)
                        : this(name, nextStudentId)
                        // "this" will call the constructor that takes two input values
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double qualityScore = grade / courseCredits;
            double totalQualityScore = (Gpa * NumberOfCredits) + qualityScore;

            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits! < 90)
            {
                return "Senior";
            }

            if (NumberOfCredits! < 60)
            {
                return "Junior";
            }

            if (NumberOfCredits! < 30)
            {
                return "Sophomore";
            }

            return "Freshman";
        }

        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(Object o)
        {
            // "cast" the input object "o" to be of type "Student"
            Student studentObj = o as Student;

            // returns true/false value
            return StudentId == studentObj.StudentId;
        }
    }
}

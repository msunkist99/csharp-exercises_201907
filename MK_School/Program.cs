using System;
using System.Collections.Generic;

namespace MK_School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();

            myStudent.Name = "Mary";
            //myStudent.StudentId = 101;
            myStudent.StudentId = 51;
            //myStudent.NumberOfCredits = 21;
            myStudent.NumberOfCredits = 20;
            myStudent.GPA = 4;

            Console.WriteLine("Name:  " + myStudent.Name);
            Console.WriteLine("Student ID:  " + myStudent.StudentId);
            Console.WriteLine("Number of Credits:  " + myStudent.NumberOfCredits);
            Console.WriteLine("GPA:  " + myStudent.GPA);

            Console.ReadLine();
        }

        public class Student
        {
            public string Name { get; set; }
            private int studentId;
            private int numberOfCredits;
            private double gpa;

            public int StudentId
            {
                get { return studentId; }
                set
                {
                    if ((value < 1) || (value > 100))
                    {
                        throw new ArgumentException("Student Id value must be between 1 and 100");
                    }
                    else
                    {
                        studentId = value;
                    }
                }
            }

            public int NumberOfCredits
            {
                get { return numberOfCredits; }
                set {
                    if ((value < 1) || (value > 20))
                    {
                        throw new ArgumentException("Number of Credits must be between 1 and 20");
                    }
                    else
                    {
                        numberOfCredits = value;
                    }
                }
            }

            public double GPA
            {
                get { return gpa; }
                internal set  { gpa = value; }
            }
        }

        public class Course
        {
            private Dictionary<int, Student> students = new Dictionary<int, Student>();
            public string Name { get; set; }
            int CreditHours { get;set }

            public Dictionary<int, Student> Students
            {
                get { return students; }

                // on the set you would probably do some validation
                set { students = value}
            }

        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace MK_School_Class6
{
    class Course
    {
        private static int nextCourseId = 1;
        public string Name { get; set; }
        public int CourseId { get; set; }
        public int NumberOfCredits { get; set; }

        public Course(string name,
                      int courseId,
                      int numberOfCredits)
        {
            Name = name;
            CourseId = courseId;
            NumberOfCredits = numberOfCredits;
        }

        public Course(string name,
                      int courseId)
                        : this(name, courseId, 0)
                        // "this" will call the constructor that takes three input values
        {
        }

        public Course(string name)
                        : this(name, nextCourseId)
                            // "this" will call the constructor that takes two input values
        {
            nextCourseId++;
        }
        public override String ToString()
        {
            return Name + " (Course: " + CourseId + "-" + Name + ", Number of Credits: " + NumberOfCredits + ")";
        }

        public override bool Equals(Object o)
        {
            // "cast" the input object "o" to be of type "Course"
            Course courseObj = o as Course;

            // returns true/false value
            return CourseId == courseObj.CourseId;
        }

    }
}

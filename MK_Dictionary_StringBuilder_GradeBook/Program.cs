using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Dictionary_StringBuilder_GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    students.Add(id, newStudent);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.Key + " (" + student.Value + ")");
                Console.WriteLine(sb);
            }

            Console.ReadLine();
        }
    }
}

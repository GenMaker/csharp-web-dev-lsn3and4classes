using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student myStudent = new Student("Pan", 001, 1, 4.0);
            Student newStudent = new Student("Tim", 002, 1, 3.9);

            ////prints out a student properties
            //Console.WriteLine(newStudent.Name);
            //Console.WriteLine(newStudent.StudentId);
            //Console.WriteLine(newStudent.NumberOfCredits);
            //Console.WriteLine(newStudent.Gpa);

            Student[] students = { myStudent, newStudent };

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine();
                students[i].DisplayInformation();
                Console.WriteLine();
            }
            
        }
    }
}

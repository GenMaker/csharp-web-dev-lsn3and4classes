using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student myStudent = new Student("Pan", 001, 1, 4.0);

            Console.WriteLine(myStudent.Name);
            Console.WriteLine(Student_Info(myStudent));
        }
    }
}

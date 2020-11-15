using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string name;

        //Auto-implemented properties for get and set
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        //Constructor
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
           Name = name;
           StudentId = studentId;
           NumberOfCredits = numberOfCredits;
           Gpa = gpa;
        }

        //In the SchoolPractice project, create a class Course with at least three fields.Before diving into Visual Studio, try using pen and paper to work through what these might be.At least one of your fields should be a List or Dictionary, and you should use your Student class.
        public string StudentInfo()
        {
            return (Name + "has a GPA of: " + Gpa);
        }

        
    }
}

using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string name;

        //Auto-implemented properties for get and set
        //??? why doesn't my setter work when name is set to private???
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        //Constructor
        public Student(string aName, int aStudentId, int aNumberOfCredits, double aGpa)
        {
            Console.WriteLine("class is instanced");
           this.Name = aName;
           this.StudentId = aStudentId;
           this.NumberOfCredits = aNumberOfCredits;
           this.Gpa = aGpa;
            Console.WriteLine("All Properties have been initialized");
        }

        //In the SchoolPractice project.At least one of your fields should be a List or Dictionary, and you should use your Student class.

        // This prints all the values of the properties to the console
        public void DisplayInformation() 
        {
            Console.WriteLine(Name);
            Console.WriteLine(StudentId);
            Console.WriteLine(NumberOfCredits);
            Console.WriteLine(Gpa);
        }


}
}

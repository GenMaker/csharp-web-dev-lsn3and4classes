using System;
namespace SchoolPractice
{
    public class Teacher
    {
        public Teacher() {
          //Using auto-implemented properties, four properties: FirstName, LastName, Subject, and YearsTeaching.

            public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public double YearsTeaching { get; set; }


        //constructor
        public Teacher(string aFirstName, string aLastName, string aSubject, double aYearTeaching)
        {
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.Subject = aSubject;
            this.YearsTeaching = aYearTeaching;

        }
    }
        
          
    
    }
    }


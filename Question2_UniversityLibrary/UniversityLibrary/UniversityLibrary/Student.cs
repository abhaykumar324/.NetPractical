
using System;

namespace UniversityLibrary
{
    public class Student
    {
        public int RollNo;
        public string Name;
        public string Course;
        public string University;

        public Student(int rollNo, string name,
            string course, string university)
        {
            RollNo = rollNo;
            Name = name;
            Course = course;
            University = university;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("--------------------");
            Console.WriteLine("Roll Number: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("University: " + University);
        }
    }
}

using System.Diagnostics;

namespace _02.UniqueStudentNames
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
            Student.counter++;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private static int counter;

        public static int Counter
        {
            get { return Student.counter; }
            set { Student.counter = value; }
        }
    }
}

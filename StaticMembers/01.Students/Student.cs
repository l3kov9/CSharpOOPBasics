namespace _01.Students
{
    public class Student
    {
        private string name;
        private static int studentCounter;

        public Student(string name)
        {
            this.name = name;
            studentCounter++;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public static int StudentCounter
        {
            get { return Student.studentCounter; }
            set { Student.studentCounter = value; }
        }


    }
}

using System;

namespace _01.Students
{
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var student=new Student(command);
            }

            Console.WriteLine(Student.StudentCounter);
        }
    }
}

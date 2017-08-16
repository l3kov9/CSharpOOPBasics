using System;

namespace _02.UniqueStudentNames
{
    public class Startup
    {
        public static void Main()
        {
            var studentGroup=new StudentGroup();
            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                studentGroup.AddMember(command);
            }

            foreach (var num in studentGroup.Students)
            {
                var student=new Student(num);
            }

            Console.WriteLine(Student.Counter);
        }
    }
}

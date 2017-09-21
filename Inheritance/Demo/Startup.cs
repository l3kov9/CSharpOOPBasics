using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            var student = new Student();
            student.School = "SoftUni";
            student.Age = 28;
            student.Name = "Lekov";

            Console.WriteLine();
        }
    }
}

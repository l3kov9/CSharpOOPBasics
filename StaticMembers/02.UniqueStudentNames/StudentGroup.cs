using System;
using System.Collections.Generic;

namespace _02.UniqueStudentNames
{
    public class StudentGroup
    {
        private HashSet<string> students;

        public HashSet<string> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public StudentGroup()
        {
            this.students=new HashSet<string>();
        }

        public void AddMember(string name)
        {
            this.students.Add(name);
        }
    }
}

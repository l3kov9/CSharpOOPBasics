using System;

namespace Demo
{
    public class Person
    {
        private string name;
        private int age;
        private string job;

        public Person(string name, int age)
        {
            if (name.Length > 3)
            {
                this.name = name;
            }
            else
            {
                throw new ArgumentException("Invalid name");
            }

            if (age > 0 && age < 60)
            {
                this.age = age;
            }
            else
            {
                throw new ArgumentException("Invalid age");
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Job
        {
            get { return this.job; }
            set { this.job = value; }
        }
    }
}

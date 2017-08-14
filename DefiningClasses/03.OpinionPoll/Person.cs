using System;

namespace _03.OpinionPoll
{
    public class Person
    {
        public Person()
        {
            if (name == null || age == null)
            {
                throw new ArgumentException("Invalid name or age");
            }

            this.name = "Unknown name";
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;
    }
}

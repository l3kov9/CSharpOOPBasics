using System;

namespace Demo
{
    public class Animal
    {
        private string name;
        private int age;
        private string color;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, int age, string color)
            : this(name, age)
        {
            this.Color = color;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException("Age must be between 0 and 50 years");
                }
                this.age = value;
            }
        }

        public string Color
        {
            get { return this.color; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid color");
                }
                this.color = value;
            }
        }

        public virtual void Talk()
        {
            Console.WriteLine("I am animal!!");
        }
    }
}

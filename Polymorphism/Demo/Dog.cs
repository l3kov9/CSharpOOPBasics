using System;

namespace Demo
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public Dog(string name, int age, string color) : base(name, age, color)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("I am an ugly dog");
        }
    }
}

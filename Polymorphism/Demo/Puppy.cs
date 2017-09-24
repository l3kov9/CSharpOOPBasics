using System;

namespace Demo
{
    public class Puppy : Dog
    {
        public Puppy(string name, int age) : base(name, age)
        {
        }

        public Puppy(string name, int age, string color) : base(name, age, color)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("PowPowPow");
        }
    }
}

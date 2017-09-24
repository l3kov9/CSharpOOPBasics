using System;

namespace Demo
{
    public class Cat : Animal
    {
        private int numberLegs;

        public Cat(string name, int age, string color, int numberLegs)
            : base(name, age, color)
        {
            this.NumberLegs = numberLegs;
        }


        public int NumberLegs
        {
            get { return this.numberLegs; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Legs must be positive number");
                }
                this.numberLegs = value;
            }
        }


        public override void Talk()
        {
            Console.WriteLine("I am a cat. Mueeayye");
        }
    }
}

using System;

namespace _01.SingleInheritance
{
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping ...");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Puppy fat enough for more eating!");
        }
    }
}

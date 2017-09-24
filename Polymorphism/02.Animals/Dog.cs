using System;

namespace _02.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override void ExplainMyself()
        {
            base.ExplainMyself();
            Console.WriteLine("Dzhaff!!!!!!!!!!!!!!!!!!!!");
        }
    }
}

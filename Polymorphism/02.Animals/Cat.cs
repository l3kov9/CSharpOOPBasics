using System;

namespace _02.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override void ExplainMyself()
        {
            base.ExplainMyself();
            Console.WriteLine("Meow!!!!!!!!!!!!!!!!!");
        }
    }
}

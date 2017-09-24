using System;

namespace _02.Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public string Name
        {
            get => this.name;
            set { this.name = value; }
        }

        public string FavouriteFood
        {
            get => this.favouriteFood;
            set { this.favouriteFood = value; }
        }

        public virtual void ExplainMyself()
        {
            Console.WriteLine($"I am {this.Name} and my favourite food is {this.FavouriteFood}.");
        }
    }
}

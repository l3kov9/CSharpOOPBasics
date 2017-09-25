namespace _02.WildFarm
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
        }

        public abstract void MakeSound();

        public void Eat(Food food)
        {
            this.foodEaten += food.quantity;
        }
    }
}

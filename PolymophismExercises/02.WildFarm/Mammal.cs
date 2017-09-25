namespace _02.WildFarm
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight)
        {
            this.livingRegion = livingRegion;
        }
    }
}

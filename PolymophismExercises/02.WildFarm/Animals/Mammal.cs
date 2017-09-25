namespace _02.WildFarm
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string name, string type, double wight, string livingRegion) 
            : base(name, type, wight)
        {
            this.livingRegion = livingRegion;
        }
    }
}

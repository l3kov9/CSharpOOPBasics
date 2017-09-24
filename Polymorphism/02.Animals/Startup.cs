namespace _02.Animals
{
    public class Startup
    {
        public static void Main()
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");

            cat.ExplainMyself();
            dog.ExplainMyself();

        }
    }
}

namespace Demo
{
    public class Dog : Animal
    {
        public string SayHello()
        {
            return $"{this.Name}: Bark";
        }
    }
}

namespace Demo
{
    public class Bunny : Animal
    {
        public Bunny()
        {
            this.Color = "White";
        }

        public string SayHello()
        {
            return $"{this.Name} : Ну заяц";
        }

        public string GetColor()
        {
            return this.Color;
        }
    }
}

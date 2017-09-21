namespace _01.SingleInheritance
{
    public class Startup
    {
        public static void Main()
        {
            var puppy=new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            var cat=new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}

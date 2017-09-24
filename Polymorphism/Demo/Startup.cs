using System;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                Animal dog=new Dog("Amper",11,"Black");
                dog.Talk();

                var cat = new Cat("Tom", 4, "Yellow", 3);
                cat.Talk();

                var puppy=new Puppy("DoggyDog",1,"Brown");
                puppy.Talk();

                Console.WriteLine(puppy is Cat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

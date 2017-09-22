using System;

namespace _05.Animals
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                var frog = new Frog("pesho", 22, "Male");
                frog.ProduceSound();

                var kitten=new Kitten("Mickey",11,"Female");
                kitten.ProduceSound();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using System;

namespace Demo
{
    public class Demo
    {
        public static void Main()
        {
            var cat=new Cat("Pesho", "Red");

            cat.Color = "Yellow";
            Console.WriteLine(cat.Color);

            Console.WriteLine(cat.GetDescription());
            Console.WriteLine(Cat.numberOfLegs());

            cat.Move(2, 4);
            
            Console.WriteLine(cat.ToString());

            cat.Attack(cat,cat, new Cat("misho","orange"));

            Console.WriteLine();
        }
    }
}

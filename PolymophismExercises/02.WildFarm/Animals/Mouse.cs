using System;

namespace _02.WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string type, double wight, string livingRegion) 
            : base(name, type, wight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }
    }
}

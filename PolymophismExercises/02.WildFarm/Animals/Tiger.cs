using System;

namespace _02.WildFarm
{
    public class Tiger : Felime
    {
        public Tiger(string name, string type, double wight, string livingRegion) 
            : base(name, type, wight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}

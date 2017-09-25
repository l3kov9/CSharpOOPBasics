using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WildFarm
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string name, string type, double wight,string livingRegion,string breed) 
            : base(name, type, wight, livingRegion)
        {
            this.breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
    }
}

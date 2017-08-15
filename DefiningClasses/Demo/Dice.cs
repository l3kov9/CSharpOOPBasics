using System;

namespace Demo
{
    public class Dice
    {
        private int sides;
        private Random rnd=new Random();

        public Dice(int sides)
        {
            this.sides = sides;
        }

        public int Sides
        {
            get
            {
                return this.sides;
            }
            set
            {
                this.sides=value;
            }
        }

        public int Roll()
        {
            this.sides = sides;

            return rnd.Next(1,sides+1);
        }
    }
}

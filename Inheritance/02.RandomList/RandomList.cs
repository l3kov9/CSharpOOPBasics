using System;
using System.Collections;

namespace _02.RandomList
{
    public class RandomList : ArrayList
    {
        private readonly Random rnd;

        public RandomList()
        {
            this.rnd=new Random();
        }

        public string RandomString()
        {
            return this.rnd.Next(100000, 2000000).ToString();
        }
    }
}

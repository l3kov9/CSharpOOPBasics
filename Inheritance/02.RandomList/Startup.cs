using System;

namespace _02.RandomList
{
    public class Startup
    {
        public static void Main()
        {
            var list=new RandomList();
            Console.WriteLine(list.RandomString());
        }
    }
}

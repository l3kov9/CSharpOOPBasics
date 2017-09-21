using System;

namespace _03.StackOfStrings
{
    public class Startup
    {
        public static void Main()
        {
            var list=new StackOfStrings{"pesho","gosho","mika"};
            list.Push("botev");
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Peek());
            list.Pop();
        }
    }
}

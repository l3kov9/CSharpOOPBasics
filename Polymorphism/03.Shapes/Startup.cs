using System;

namespace _03.Shapes
{
    public class Startup
    {
        public static void Main()
        {
            var rectangle=new Rectangle(1,4);
            Console.WriteLine(rectangle.CalculatePerimeter());
        }
    }
}

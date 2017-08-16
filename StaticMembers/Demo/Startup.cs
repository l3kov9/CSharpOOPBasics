using System;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            var john=new Englishman();
            var sussy=new Englishman();
            var ivan=new Englishman();

            //Console.WriteLine(Person.Counter);
            var gosho=new Person("Gosho",22);
            var vince=new Person("Vince",33);
            //Console.WriteLine(Person.Counter);

            var number=new Number(6);
            Console.WriteLine(Number.Triple(number.Num));
        }
    }
}

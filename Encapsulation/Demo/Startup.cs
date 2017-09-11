using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            //var rows = int.Parse(Console.ReadLine());
            //var cols = int.Parse(Console.ReadLine());

            //var chess=new int[rows,cols];

            //for (int i = 1; i < chess.GetLength(0); i++)
            //{
            //    for (int j = 0; j < chess.GetLength(1); j++)
            //    {
            //        if ((i-1>=0 && chess[i-1,j]==0) && ((i+1<rows) && chess[i+1,j]==0)
            //            && ((j-1>=0) && chess[i,j-1]==0) && ((j+1<cols) && chess[i,j+1]==0))
            //        {
            //            chess[i, j] = 1;
            //        }
            //    }
            //}

            //var counter = 0;

            //for (int i = 0; i < chess.GetLength(0); i++)
            //{
            //    for (int j = 0; j < chess.GetLength(1); j++)
            //    {
            //        counter += chess[i, j];
            //    }
            //}

            //Console.WriteLine(counter);

            var emp = new Employee("pesho", 22);
            var age = emp.Age;

            Console.WriteLine(age);


            var person = new Person("Lekov", 27) { Job = "Footballer" };
            var people = new List<Person>();
            people.Add(person);

            var footballJob = people
                .FirstOrDefault(x => x.Name == "Lekov")
                .Job;

            Console.WriteLine(footballJob);


            var sexyBunny = new Bunny()
            {
                Name = "Nasko",
                Age = 28
            };
            var pluto = new Dog();

            Console.WriteLine(pluto.SayHello());
            Console.WriteLine(sexyBunny.SayHello());
        }
    }
}

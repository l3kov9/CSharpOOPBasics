using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.OpinionPoll
{
    public class OpinionPoll
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons=new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                persons.Add(new Person(tokens[0],int.Parse(tokens[1])));
            }

            persons
                .Where(x=>x.age>30)
                .OrderBy(x=>x.name)
                .ToList()
                .ForEach(x=>Console.WriteLine($"{x.name} - {x.age}"));
        }
    }
}

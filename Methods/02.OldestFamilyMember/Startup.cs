using System;

namespace _02.OldestFamilyMember
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfPersons = int.Parse(Console.ReadLine());
            var family=new Family();

            for (int i = 0; i < numberOfPersons; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}

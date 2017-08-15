using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people=new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.people.OrderByDescending(x => x.Age)
                .FirstOrDefault();
        }
    }
}

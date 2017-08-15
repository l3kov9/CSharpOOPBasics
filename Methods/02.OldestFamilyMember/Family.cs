using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public List<Person> Members
        {
            get { return this.members; }
            set { this.members = members; }
        }

        public void AddMember(Person person)
        {
            this.members.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldestMember = this.members.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestMember;
        }
    }
}

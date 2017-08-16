namespace Demo
{
    public class Person
    {
        private static int counter;

        public static int Counter
        {
            get { return Person.counter; }
        }

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

            Person.counter++;
        }
    }
}

namespace Demo
{
    public class Employee
    {
        private string name;
        private int age;
        private decimal monthlySalary;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 1)
                {
                    
                }
                this.name = value;
            }
        }

        public int Age => this.age;
    }
}

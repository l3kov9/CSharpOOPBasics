using System;

namespace SortPersonByNameAndAge
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            

            get { return this.firstName; }
            set
            {
                if (value.Length < 2 || value == null)
                {
                    throw new ArgumentException($"{nameof(FirstName)} is invalid");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 2 || value == null)
                {
                    throw new ArgumentException($"{nameof(LastName)} is invalid");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100 || value == null)
                {
                    throw new ArgumentException($"{nameof(LastName)} is invalid");
                }

                this.age = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException($"{nameof(Salary)} cannot be less than 460 leva.");
                }

                this.salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.Salary:f2} leva";
        }

        public void IncreaseSalary(decimal bonus)
        {
            if (this.age < 30)
            {
                this.salary += this.salary*bonus/200m;
            }
            else
            {
                this.salary += this.salary*bonus/100m;
            }
        }
    }
    
}

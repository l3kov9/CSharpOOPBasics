﻿namespace _04.CompanyRoster
{
    public class Employee
    {
        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;
    }
}

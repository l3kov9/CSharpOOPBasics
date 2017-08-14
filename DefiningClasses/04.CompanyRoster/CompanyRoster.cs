using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CompanyRoster
{
    public class CompanyRoster
    {
        public static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());
            var employees=new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var employee=new Employee(tokens[0],decimal.Parse(tokens[1]),tokens[2],tokens[3]);

                if (tokens.Length > 4)
                {
                    if (tokens[4].Contains("@"))
                    {
                        employee.email = tokens[4];
                    }
                    else
                    {
                        employee.age = int.Parse(tokens[4]);
                    }
                }

                if (tokens.Length > 5)
                {
                    employee.age = int.Parse(tokens[5]);
                }

                employees.Add(employee);
            }

            var result = employees
                .GroupBy(x => x.department)
                .Select(x=>new
                {
                    Department=x.Key,
                    AverageSalary=x.Average(emp=>emp.salary),
                    Employees=x.OrderByDescending(emp=>emp.salary)
                })
                .OrderByDescending(x=>x.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Department}");
            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.name} {employee.salary:f2} {employee.email} {employee.age}");
            }
        }
    }
}

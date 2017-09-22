using System.Text;

namespace _03.Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;

        private decimal workHoursPerDay;

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }


        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }


        public Worker(string firstName, string lastName,decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal CalculateSalaryPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5m);
        }

        public override string ToString()
        {
            var sb=new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Week hours per day: {this.WorkHoursPerDay:f2}")
                .AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():f2}");

            return sb.ToString();
        }
    }
}

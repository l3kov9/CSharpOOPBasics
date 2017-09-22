using System;
using System.Text;

namespace _03.Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Last name must start with a capital letter");
                }
                this.lastName = value;
            }
        }


        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("First name must start with a capital letter");
                }
                if (value.Length < 4)
                {
                    throw new ArgumentException("First name must be more than 3 letters");
                }
                this.firstName = value;
            }
        }

        public override string ToString()
        {
            var sb=new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}");
            return sb.ToString();
        }
    }
}

using System;

namespace _10.Bank
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public BankAccount()
        {
            this.ID = id;
            this.Balance = balance;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public void PrintBankBalance()
        {
            Console.WriteLine($"Account id: {this.id}\nBalance: {this.balance}");
        }

        public override string ToString()
        {
            return $"Account id: {this.id}\nBalance: {this.balance}";
        }
    }
}

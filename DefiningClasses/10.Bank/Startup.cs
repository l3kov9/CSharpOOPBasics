using System;

namespace _10.Bank
{
    public class Startup
    {
        public static void Main()
        {
            var account=new BankAccount();
            account.ID = 1;
            account.Balance = 15;

            account.PrintBankBalance();

            account.Withdraw(10);
            account.Deposit(100);
            Console.WriteLine(account.ToString());
        }
    }
}

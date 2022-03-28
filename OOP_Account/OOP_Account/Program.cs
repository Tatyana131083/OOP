using System;

namespace OOP_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account2 = new Account();

            account1.SetAccountNumber(471158790025);
            account1.SetAccountType(AccountType.Текущий);
            account1.SetBalance(12000.00M);

            account2.SetAccountNumber(471158790026);
            account2.SetAccountType(AccountType.Депозитный);
            account2.SetBalance(240000.00M);

            Console.WriteLine($"Number - {account1.GetAccountNumber()}; Type - {account1.GetAccountType()}; Balance - {account1.GetBalance()}");
            Console.WriteLine($"Number - {account2.GetAccountNumber()}; Type - {account2.GetAccountType()}; Balance - {account2.GetBalance()}");
        }
    }
}

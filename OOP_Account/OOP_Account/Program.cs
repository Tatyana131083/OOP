using System;

namespace OOP_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(AccountType.Текущий);
            Account account2 = new Account(AccountType.Депозитный, 240000.00M);

            Console.WriteLine($"Number - {account1.GetAccountNumber()}; Type - {account1.GetAccountType()}; Balance - {account1.GetBalance()}");
            Console.WriteLine($"Number - {account2.GetAccountNumber()}; Type - {account2.GetAccountType()}; Balance - {account2.GetBalance()}");
        }
    }
}

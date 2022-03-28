using System;

namespace OOP_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(AccountType.Текущий);
            Account account2 = new Account(AccountType.Депозитный, 240000.00M);

            Console.WriteLine($"Number - {account1.AccountNumber}; Type - {account1.Type}; Balance - {account1.Balance}");
            Console.WriteLine($"Number - {account2.AccountNumber}; Type - {account2.Type}; Balance - {account2.Balance}");
        }
    }
}

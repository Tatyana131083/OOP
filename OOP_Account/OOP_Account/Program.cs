using System;

namespace OOP_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(AccountType.Current);            
            Account account2 = new Account(AccountType.Deposit, 240000.00M);

            Console.WriteLine(account1);
            account1.Deposit(10000);
            Console.WriteLine("Пополнение счета на 10000 руб.");
            Console.WriteLine(account1);

            Console.WriteLine(account2);
            account2.Withdrawal(45000);
            Console.WriteLine("Снятие со счета 45000 руб.");
            Console.WriteLine(account2);

            account1.Transaction(account2, 100000M);
            Console.WriteLine(account1);
            Console.WriteLine(account2);

            if(account1 == account2)
                Console.WriteLine($"{account1.AccountNumber} == {account2.AccountNumber}");
            else
                Console.WriteLine($"{account1.AccountNumber} != {account2.AccountNumber}");
        }
    }
}

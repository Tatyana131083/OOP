using System;

namespace OOP_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(AccountType.Текущий);            
            Account account2 = new Account(AccountType.Депозитный, 240000.00M);
            

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
        }
    }
}

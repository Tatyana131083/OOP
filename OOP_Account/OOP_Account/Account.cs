

internal enum AccountType
{
    Текущий,
    Расчетный,
    Кредитный,
    Депозитный
}
namespace OOP_Account
{
    internal class Account
    {
        static private long _number = 471158790040;
        private long _accountNumber;
        private AccountType _accountType;
        private decimal _balance;


        public Account(decimal balance) : this(AccountType.Текущий, balance) {} 

        public Account(AccountType accountType) : this(accountType, 0.0M) {}

        public Account(AccountType accountType, decimal balance)
        {
            _accountType = accountType;
            _balance = balance;
            _accountNumber = ++_number;
        }


        public AccountType Type
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = value;
            }
        }


        public long AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value > 0.0M)
                {
                    _balance = value;
                }
            }
        }

        /// <summary>
        /// Пополнение счета
        /// </summary>
        /// <param name="depositAmount">Сумма пополнения</param>
        public void Deposit(decimal depositAmount)
        {                                                                 
            if (depositAmount > 0.0m) 
            {                                                             
                Balance = Balance + depositAmount; 
            }                                                             
        }

        /// <summary>
        /// Снятие со счета
        /// </summary>
        /// <param name="withdrawalAmount">Сумма снятия</param>
        public void Withdrawal(decimal withdrawalAmount)
        {
            if (Balance >= withdrawalAmount)
            {
                Balance = Balance - withdrawalAmount;
            }
        }

        public override string ToString()
        {
            return $"Number - {AccountNumber}; Type - {Type}; Balance - {Balance:C}";
        }

        /// <summary>
        /// Перевод деньг с одного счета на другой
        /// </summary>
        /// <param name="fromAccount">Счет откуда снимаются деньги</param>
        /// <param name="amount">Сумма перевода</param>
        public bool Transaction(Account fromAccount, decimal amount)
        {
            if(fromAccount.Balance >= amount && amount > 0M)
            {
                fromAccount.Balance -= amount;
                this.Balance += amount;
                return true;
            }
            return false;
        }


    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            SetNumber();
            _accountNumber = _number;
        }

        static private void SetNumber()
        {
            _number++;
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


    }

}


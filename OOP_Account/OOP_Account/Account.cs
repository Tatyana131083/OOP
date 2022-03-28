﻿using System;
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
        private long _accountNumber;
        private AccountType _accountType;
        private decimal _balance;
        
        public void SetAccountNumber(long accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public long GetAccountNumber()
        {
            return _accountNumber;
        }

        public void SetAccountType(AccountType accountType)
        {
            _accountType = accountType;
        }

        public AccountType GetAccountType()
        {
            return _accountType;
        }

        public void SetBalance(decimal balance)
        {
            if(balance > 0.0M)
            {
                _balance = balance;
            }            
        }

        public decimal GetBalance()
        {
            return _balance;
        }

    }

}

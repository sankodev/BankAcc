using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IC22_KS_BankAcc
{
    public class CheckingAccount : BankAccount
    {
        private bool _overdraftProtection;

        public CheckingAccount(string accountNumber, string customerId, decimal balance, string name, string creditScore, bool overdraftProtection)
        {
            //throw new System.NotImplementedException();
            _accountNumber = accountNumber;
            _customerId = customerId;
            _balance = balance;
            _name = name;
            _creditScore = creditScore;
            _overdraftProtection = overdraftProtection;
        }
    
        public bool OverdraftProtection
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public override bool Deposit(decimal transactionAmount)
        {
            throw new NotImplementedException();
        }

        public override bool Withdraw(decimal transactionAmount)
        {
            throw new NotImplementedException();
        }
    }
}

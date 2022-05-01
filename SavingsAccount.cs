using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IC22_KS_BankAcc
{
    public class SavingsAccount : BankAccount
    {
        private double _interestRate;

        public SavingsAccount(string accountNumber, string customerId, decimal balance, string name, string creditScore, double interestRate)
        {
            //throw new System.NotImplementedException();

            _accountNumber = accountNumber;
            _customerId = customerId;
            _balance = balance;
            _name = name;
            _creditScore = creditScore;
            _interestRate = interestRate;
        }

        public double InterestRate
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

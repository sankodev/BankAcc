using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IC22_KS_BankAcc
{
    public abstract class BankAccount
    {
        //class
        //private string _customerId;
        //private decimal _balance;
        //private string _accountNumber;
        //private string _name;
        //private string _creditScore;

        protected string _customerId;
        protected decimal _balance;
        protected string _accountNumber;
        protected string _name;
        protected string _creditScore;

        //Constructor

        //properties
        public string CustomerId
        {
            get
            {
                return _customerId;
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
                _balance = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }

        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string CreditScore
        {
            get
            {
                return _creditScore;
            }
        }

        //ToString()

        public abstract bool Deposit(decimal transactionAmount);
        //{
        //    //throw new System.NotImplementedException();
        //    //if (transactionAmount <= 0m)
        //    //{
        //    //    return false;
        //    //}
        //    //else
        //    //{
        //    //    _balance += transactionAmount;
        //    //    return true;
        //    //}
        //}

        public abstract bool Withdraw(decimal transactionAmount);
        //{
        //    //throw new System.NotImplementedException();
        //    if (transactionAmount <= 0m)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        _balance -= transactionAmount;
        //        return true;
        //    }
        //}
    }
}

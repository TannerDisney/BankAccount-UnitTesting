using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountUnitTesting
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string FullName { get; set; }
        public double Balance { get; private set; }

        /// <summary>
        /// Subtracts amount from the current balance
        /// </summary>
        /// <param name="amount">Amount to be withdrawn from balance</param>
        /// <returns></returns>
        public double Withdraw(double amount)
        {
            if (amount > Balance)
                throw new ArgumentException($"{nameof(amount)} cannot be greater than the balance in the account");
            else
                Balance -= amount;
                return Balance;
        }

        /// <summary>
        /// Adds amount to the current balance
        /// </summary>
        /// <param name="amount">Amount to be deposited into balance</param>
        /// <returns></returns>
        public double Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException($"{nameof(amount)} cannot be zero or less");
            else
                Balance += amount;
                return Balance;
        }

        /// <summary>
        /// View the current balance
        /// </summary>
        /// <returns></returns>
        public double ViewBalance()
        {
            return Balance;
        }
    }
}

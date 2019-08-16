using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountUnitTesting.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Withdraw_PositiveAmount_RemovesFromBalance()
        {
            // Arrange
            /* Have to add to balance to start to see if this works */
            Account Checking = new Account();
            double depositAmount = 150;

            double withdrawAmount = 50;
            double expectedBalance = 100;

            // Act
            Checking.Deposit(depositAmount);
            double result = Checking.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(expectedBalance, result);
        }

        [TestMethod()]
        public void Withdraw_NegativeAmount_ThrowsException()
        {
            // Arrange
            Account Checking = new Account();
            double WithdrawAmount = 50;

            // Act => Assert
            Assert.ThrowsException<ArgumentException>
                (() => Checking.Withdraw(WithdrawAmount));
        }

        [TestMethod()]
        public void Deposit_PositiveAmount_AddsToBalance()
        {
            // Arrange
            Account Checking = new Account();
            double depositAmount = 50;
            double expectedBalance = 50;

            // Act
            double result = Checking.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedBalance, depositAmount);
        }
    }
}
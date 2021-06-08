using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;

namespace BankTestJOB_2021
{
    [TestClass]
    public class BankAccountTestsJOB_2021
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        // unit test code
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // preparaci�n del caso de prueba
            double beginningBalance= 11.99; 
            double debitAmount =4.55; 
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton",beginningBalance);
            // acci�n a probar
            account.Debit(debitAmount);
            // afirmaci�n de la prueba (valor esperado Vs. Valor obtenido)
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        //unit test method
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Debit_WhenBankAccountIsFrezee_ShouldThrowException() 
        {
            // preparaci�n del caso de prueba
            double beginningBalance = 11.99;
            double debitAmount = 20.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.FreezeAccount();
            account.Debit(debitAmount);
           
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // act
            try
            {
             account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void DebitAmountLessThanZeroMessage()
        {
            double beginingBalance = 11.99;
            double debitAmount = -100;

            BankAccount account = new BankAccount("Mr. Bryan Walton", beginingBalance);
            try
            {
                account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountLessThanZeroMessage);
            }
        }
    }
}

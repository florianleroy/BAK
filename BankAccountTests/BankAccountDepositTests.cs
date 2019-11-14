using BankAccountLibrary;
using NFluent;
using NUnit.Framework;

namespace BankAccountTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BankAccount_AmountDeposit_Increases_Balance()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(1000);
            Balance oldBalance = bankAccount.Balance;

            //When
            bankAccount.Deposit(amount);
            Balance expectedBalance = oldBalance + amount;

            //Then
            Check.That(bankAccount.Balance).Equals(expectedBalance);
        }
    }
}
using System;
using NUnit;
using NUnit.Framework;
using TAU1Testy;

namespace CalculatorUnitetst
{
    class BankTests
    {
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalnce = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Calculator account = new Calculator("Mr. Bryan Walton", beginningBalnce);

            account.Debit(debitAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}

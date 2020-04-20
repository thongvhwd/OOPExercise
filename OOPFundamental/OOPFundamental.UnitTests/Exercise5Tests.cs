using Exercise5.Models;
using NUnit.Framework;
namespace OOPFundamental.UnitTests
{
    [TestFixture]
    public class Exercise5Tests
    {


        [TestCase(100, 110, 210)]
        [TestCase(100, 20, 120)]
        [TestCase(200, 100, 300)]
        public void Deposit_WhenUsingDepositAccount_IsCorrected(decimal balance, decimal amount, decimal expected)
        {
            var account = new DepositAccount()
            {
                Balance = balance,
                Customer = new Individual() { Name = "Batman" },
                InterestRate = 1.1f
            };
            account.Deposit(amount);
            Assert.AreEqual(expected, account.Balance);
        }

        [TestCase(100, 10, 90)]
        [TestCase(200, 80, 120)]
        [TestCase(100, 20, 80)]
        public void Withdraw_WhenUsingDepositAccount_IsCorrected(decimal balance, decimal amount, decimal expected)
        {
            var account = new DepositAccount()
            {
                Balance = balance,
                Customer = new Individual() { Name = "Superman" },
                InterestRate = 1.1f
            };
            account.WithDraw(amount);
            Assert.AreEqual(expected, account.Balance);
        }
        [TestCase(120, 100, 220)]
        [TestCase(300, 20, 320)]
        [TestCase(550, 100, 650)]
        public void Deposit_WhenUsingLoanAccount_IsCorrected(decimal balance, decimal amount, decimal expected)
        {
            var account = new LoanAccount()
            {
                Balance = balance,
                Customer = new Individual() { Name = "Batman" },
                InterestRate = 1.1f
            };
            account.Deposit(amount);
            Assert.AreEqual(expected, account.Balance);
        }
        [TestCase(150000, 5000, 155000)]
        [TestCase(21000, 2000, 23000)]
        [TestCase(1200000, 2000000, 3200000)]
        public void Deposit_WhenUsingMortgageAccount_IsCorrected(decimal balance, decimal amount, decimal expected)
        {
            var account = new MortgageAccount()
            {
                Balance = balance,
                Customer = new Company() { Name = "Stark Industries" },
                InterestRate = 1.1f
            };
            account.Deposit(amount);
            Assert.AreEqual(expected, account.Balance);
        }
    }
}

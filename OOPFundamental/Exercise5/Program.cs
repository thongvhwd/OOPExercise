using Exercise5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test deposit account
            var depositAccount = new DepositAccount()
            {
                Balance = 100m,
                Customer = new Individual() { Name = "Batman"},
                InterestRate = 1.1f
            };
            Console.WriteLine($"{depositAccount.Customer.Name} transactions----BEGIN");
            ShowCurrentBalance(depositAccount);
            depositAccount.Deposit(10);
            ShowCurrentBalance(depositAccount);
            depositAccount.WithDraw(10);
            ShowCurrentBalance(depositAccount);
            Console.WriteLine($"{depositAccount.Customer.Name} transactions----END");
            #endregion

            #region test loan account
            var loanAccount = new LoanAccount()
            {
                Balance = 15m,
                Customer = new Individual() { Name = "Superman" },
                InterestRate = 0.5f
            };
            Console.WriteLine($"{loanAccount.Customer.Name} transactions----BEGIN");
            ShowCurrentBalance(loanAccount);
            loanAccount.Deposit(10);
            ShowCurrentBalance(loanAccount);
            Console.WriteLine($"{loanAccount.Customer.Name} transactions----END");
            #endregion

            #region test mortgage account
            var mortgageAccount = new MortgageAccount()
            {
                Balance = 15000m,
                Customer = new Company() { Name = "Stark Industries" },
                InterestRate = 0.7f
            };
            Console.WriteLine($"{mortgageAccount.Customer.Name} transactions----BEGIN");
            ShowCurrentBalance(mortgageAccount);
            mortgageAccount.Deposit(100);
            ShowCurrentBalance(mortgageAccount);
            Console.WriteLine($"{mortgageAccount.Customer.Name} transactions----END");
            #endregion
            Console.ReadLine();

        }
        static void ShowCurrentBalance(Account account)
        {
            Console.WriteLine($"Current Balance of {account.Customer.Name} is: {account.Balance}");

        }
    }
}

using Exercise5.Interfaces;
using Exercise5.Utils;

namespace Exercise5.Models
{
    public class LoanAccount : Account, IDepositable
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
            AccountUtil.Deposit(amount);
        }
    }
}

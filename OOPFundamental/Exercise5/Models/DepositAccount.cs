using Exercise5.Interfaces;
using Exercise5.Utils;

namespace Exercise5.Models
{
    public class DepositAccount : Account, IDepositable, IWithDrawable
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
            AccountUtil.Deposit(amount);
        }

        public void WithDraw(decimal amount)
        {
            Balance -= amount;
            AccountUtil.WithDraw(amount);
        }
    }
}

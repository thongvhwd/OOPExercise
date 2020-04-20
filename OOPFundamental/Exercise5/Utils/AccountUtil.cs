using System;

namespace Exercise5.Utils
{
    static class AccountUtil
    {
       public static void WithDraw(decimal balance)
        {
            Console.WriteLine($"Current balance -{balance}");
        }
        public static void Deposit(decimal balance)
        {
            Console.WriteLine($"Current balance +{balance}");
        }
    }
}

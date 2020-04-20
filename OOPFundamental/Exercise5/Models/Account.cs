namespace Exercise5.Models
{
    public abstract class Account
    {
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }
        public float InterestRate { get; set; }

    }
}

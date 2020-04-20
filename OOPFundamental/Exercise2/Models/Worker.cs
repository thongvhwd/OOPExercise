namespace Exercise2.Models
{
    public class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public decimal CalculateMoneyPerHour()
        {
            return WeekSalary / (decimal)(7 * WorkHoursPerDay);
        }
    }
}

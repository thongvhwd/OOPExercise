using System;
using System.Collections.Generic;
using Exercise2.Models;
using NUnit.Framework;
namespace OOPFundamental.UnitTests
{
    [TestFixture]
    public class Exercise2Tests
    {
        public static IEnumerable<TestCaseData> CalculateMoneyPerHourOfWorkerIsCorrectedTestCases
        {
            get
            {
                yield return new TestCaseData(new Worker()
                {
                    FirstName = "C",
                    LastName = "Nguyễn Văn",
                    WeekSalary = 490,
                    WorkHoursPerDay = 10
                }, 7);
                yield return new TestCaseData(new Worker()
                {
                    FirstName = "C",
                    LastName = "Nguyễn Văn",
                    WeekSalary = 245m,
                    WorkHoursPerDay = 7
                }, 5);
                yield return new TestCaseData(new Worker()
                {
                    FirstName = "C",
                    LastName = "Nguyễn Văn",
                    WeekSalary = 700m,
                    WorkHoursPerDay = 10
                }, 10);
            }
        }

        [TestCaseSource("CalculateMoneyPerHourOfWorkerIsCorrectedTestCases")]
        public void CalculateMoneyPerHour_OfWorker_IsCorrected(Worker worker, double moneyPerHour)
        {
            Assert.AreEqual(moneyPerHour, worker.CalculateMoneyPerHour());
        }
    }
}

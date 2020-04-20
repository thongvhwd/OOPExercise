using Exercise2.Models;
using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var students = new[]
            {
                new Student() {FirstName = "A",LastName="Nguyễn",Grade =5  },
                new Student() {FirstName = "B",LastName="Nguyễn",Grade =5  },
                new Student() {FirstName = "C",LastName="Nguyễn",Grade =1  },
                new Student() {FirstName = "D",LastName="Nguyễn",Grade =4  },
                new Student() {FirstName = "E",LastName="Nguyễn",Grade =5  },
                new Student() {FirstName = "F",LastName="Nguyễn",Grade =7  },
                new Student() {FirstName = "G",LastName="Nguyễn",Grade =7  },
                new Student() {FirstName = "H",LastName="Nguyễn",Grade =9  },
                new Student() {FirstName = "K",LastName="Nguyễn",Grade =10  },
                new Student() {FirstName = "Q",LastName="Nguyễn",Grade =10  },
            };

            Console.WriteLine("Student list by ascending grade:");
            foreach (var student in students.OrderBy(s => s.Grade))
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName} has grade is {student.Grade}");
            }

            var workers = new[]
            {
                new Worker() { FirstName = "A",LastName="Nguyễn Văn",WeekSalary = 420m, WorkHoursPerDay = 6.5  },
                new Worker() { FirstName = "B",LastName="Nguyễn Văn",WeekSalary = 490m, WorkHoursPerDay = 7.5  },
                new Worker() { FirstName = "C",LastName="Nguyễn Văn",WeekSalary = 350m, WorkHoursPerDay = 10  },
                new Worker() { FirstName = "D",LastName="Nguyễn Văn",WeekSalary = 700m, WorkHoursPerDay = 5  },
                new Worker() { FirstName = "E",LastName="Nguyễn Văn",WeekSalary = 777m, WorkHoursPerDay = 7  },
                new Worker() { FirstName = "F",LastName="Nguyễn Văn",WeekSalary = 1500m, WorkHoursPerDay = 5  },
                new Worker() { FirstName = "G",LastName="Nguyễn Văn",WeekSalary = 750m, WorkHoursPerDay = 4  },
                new Worker() { FirstName = "H",LastName="Nguyễn Văn",WeekSalary = 650m, WorkHoursPerDay = 7.5  },
                new Worker() { FirstName = "K",LastName="Nguyễn Văn",WeekSalary = 450m, WorkHoursPerDay = 5.5  },
                new Worker() { FirstName = "L",LastName="Nguyễn Văn",WeekSalary = 250m, WorkHoursPerDay = 3.5  },
            };
            Console.WriteLine("Worker list by descending money per hour:");

            foreach (var worker in workers.OrderByDescending(w => w.CalculateMoneyPerHour()))
            {
                Console.WriteLine($"Worker: {worker.FirstName} {worker.LastName} has money per hour is {worker.CalculateMoneyPerHour()}");
            }
            Console.ReadLine();
        }
    }
}

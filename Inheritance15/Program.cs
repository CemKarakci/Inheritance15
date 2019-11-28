using System;
using System.Collections.Generic;

namespace Inheritance15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pay an hourly employee Bob who works for 40 hours
            // Bob's hourly rate is $27.50
            var hourly = new HourlyEmployee();
            hourly.HourlyPay = 27.50;
            hourly.HoursWorked = 40;

            // Pay a salaried employee Steve who works one week.
            // Steve's yearly salary is $50,000

            var weekly = new SalaryEmployee();
            //weekly.WeeksInYear = 52;
            //weekly.TotalPayPerYear = 50000;

            // weekly.PayEmployee();
            var employees = new List<Employee>();
            employees.Add(hourly);
            employees.Add(weekly);

            PayEmployees(employees);
            Console.ReadLine();


           
        }

        static void PayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                employee.PayEmployee();
               
            }
        }
    }

    abstract class Employee
    {
        public string Name { get; set; }

        public abstract void PayEmployee();
    }

    class HourlyEmployee : Employee
    {
        public double HourlyPay { get; set; }
        public double HoursWorked { get; set; }

        double payment = 0.0;
        public override void PayEmployee()
        {
            Name = "Bob";
            payment = HourlyPay * HoursWorked;
            Console.WriteLine($"{Name} will be paid {payment}");            
        }
    }

    class SalaryEmployee : Employee
    {
        double payment = 0.0;
        public double WeeksInYear { get; set; }
        public double  TotalPayPerYear{ get; set; }

        public SalaryEmployee()
        {
            Name = "Steve";
            WeeksInYear = 52;
            TotalPayPerYear = 50000;
        }

        public override void PayEmployee()
        {            
           // Name = "Steve";
            payment = TotalPayPerYear / WeeksInYear;
            Console.WriteLine($"{Name} will be paid {payment}");
        }       
    }
}

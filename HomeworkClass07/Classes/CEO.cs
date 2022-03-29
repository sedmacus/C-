using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        protected double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, Employee[] employees, int shares)
            : base(firstName, lastName, Role.CEO, 2900)
        {
            Employees = employees;
            Shares = shares;
        }

        public void AddSharesPrice(double sharePrice)
        {
            SharesPrice = sharePrice;
        }

        public void PrintEmployees()
        {
            foreach(Employee e in Employees)
            {
                Console.WriteLine(e.FullName);
            }
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} Shares: {Shares} ";
        }
    }
}

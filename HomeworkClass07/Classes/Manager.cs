using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public string Department { get; set; }

        public Manager(string firstName, string lastName, double salary, string department)
            : base(firstName, lastName, Role.Manager, salary)
        {
            Bonus = 0;
            Department = department;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}

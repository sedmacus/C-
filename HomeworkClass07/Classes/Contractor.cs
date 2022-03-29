using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager manager)
            : base(firstName, lastName, Role.Contractor, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = manager;
        }

        public override double GetSalary()
        {
             return Salary = WorkHours * PayPerHour;
            
        }

        public string CurrentPosition()
        {
            return $"{Responsible.Department}";
        }

        public override string GetInfo()
        {
            return $"{FullName} {Role} Department: {Responsible.Department} [{GetSalary():C}]";
        }


    }
}

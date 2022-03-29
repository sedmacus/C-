using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
            : base(firstName, lastName, Role.Sales, 500)
        {
            SuccessSaleRevenue = 0;
        }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            
            double bonus = 500;

            if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                bonus = 1500;
            }

            return Salary + bonus;
        }
    }
}

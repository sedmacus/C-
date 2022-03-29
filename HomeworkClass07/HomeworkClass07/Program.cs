using System;
using Classes;

namespace HomeworkClass07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesPerson s = new SalesPerson("Bob", "Bobsky");

            Manager m = new Manager("Mona", "Monalisa", 2000, "Public Relations");
            Manager m1 = new Manager("Petko", "Petkovski", 2000, "Human resources");

            Contractor c = new Contractor("Rick", "Rickert", 210, 10, m1);
            Contractor c1 = new Contractor("Ana", "Anyshka", 160, 10, m);

            Employee[] company = new Employee[5];
            company[0] = s;
            company[1] = m;
            company[2] = m1;
            company[3] = c;
            company[4] = c1;

            CEO ceo = new CEO("Martin", "Brzovski", company, 8000);
            ceo.AddSharesPrice(250);

            Console.WriteLine(ceo.GetInfo());
            Console.WriteLine(ceo.GetSalary());

           // Console.WriteLine(ceo.PrintEmployees());





        }
    }
}

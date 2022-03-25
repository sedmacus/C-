using System;

namespace HomeworkClass05
{
    internal class Program
    {
       
        public static void RaceCars(Car a, Car b, Driver x, Driver y)
        {
            if (a.CalculateSpeed(x) > b.CalculateSpeed(y))
            {
                Console.WriteLine($"First Car, model {a.Model} is faster than the second car model {b.Model}.\n{a.Model} was driving with top speed of {a.Speed} km/h, and the driver was {x.Name}.");
            }
            else if (a.CalculateSpeed(x) < b.CalculateSpeed(y))
            {
                Console.WriteLine($"Second Car, model {b.Model} is faster than the first car model {a.Model}.\n{b.Model} was driving with top speed of {b.Speed} km/h, and the driver was {y.Name}.");
            }
            else
            {
                Console.WriteLine("Nobody won the race..");
            }
        }
        
        
        static void Main(string[] args)
        {

            Driver bob = new Driver("Bob", 10);
            Driver greg = new Driver("Greg", 6);
            Driver jill = new Driver("Jill", 3);
            Driver anne = new Driver("Anne", 8);

            Car hyundai = new Car();
            hyundai.Model = "Hyundai";
            hyundai.Speed = 250;
            
            Car mazda = new Car();
            mazda.Model = "Mazda";
            mazda.Speed = 170;
            
            Car ferrari = new Car();
            ferrari.Model = "Ferrari";
            ferrari.Speed = 330;

            Car porsche = new Car();
            porsche.Model = "Porsche";
            porsche.Speed = 280;

            Car firstCar = new Car();
            Car secondCar = new Car();
            Driver firstDriver = new Driver();
            Driver secondDriver = new Driver();
            
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Chose a car no.1: \n 1) Hyundai \n 2) Mazda \n 3) Ferrari \n 4) Porsche ");
                    string firstInput = Console.ReadLine();

                    switch (firstInput.ToLower())
                    {
                        case "hyundai":
                            firstCar.Model = "Hyundai";
                            firstCar.Speed = 250;
                            break;
                        case "mazda":
                            firstCar.Model = "Mazda";
                            firstCar.Speed = 170;
                            break;
                        case "ferrari":
                            firstCar.Model = "Ferrari";
                            firstCar.Speed = 330;
                            break;
                        case "porsche":
                            firstCar.Model = "Porsche";
                            firstCar.Speed = 280;
                            break;
                        default:
                            Console.WriteLine("Please select car");
                            continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Please select Driver for the 1st car: \n 1) Bob \n 2) Greg \n 3) Jill \n 4) Anne");
                    string firstinputDriver = Console.ReadLine();

                    switch (firstinputDriver.ToLower())
                    {
                        case "bob":
                            firstDriver.Name = "Bob";
                            firstDriver.Skill = 10;
                            break;
                        case "greg":
                            firstDriver.Name = "Greg";
                            firstDriver.Skill = 6;
                            break;
                        case "jill":
                            firstDriver.Name = "Jill";
                            firstDriver.Skill = 3;
                            break;
                        case "anne":
                            firstDriver.Name = "Anne";
                            firstDriver.Skill = 8;
                            break;
                        default:
                            Console.WriteLine("Please select Driver");
                            continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Chose a car no.2: \n 1) Hyundai \n 2) Mazda \n 3) Ferrari \n 4) Porsche ");
                    string secondInput = Console.ReadLine();

                    switch (secondInput.ToLower())
                    {
                        case "hyundai":
                            secondCar.Model = "Hyundai";
                            secondCar.Speed = 250;
                            break;
                        case "mazda":
                            secondCar.Model = "Mazda";
                            secondCar.Speed = 170;
                            break;
                        case "ferrari":
                            secondCar.Model = "Ferrari";
                            secondCar.Speed = 330;
                            break;
                        case "porsche":
                            secondCar.Model = "Porsche";
                            secondCar.Speed = 280;
                            break;
                        default:
                            Console.WriteLine("Please select car");
                            continue;
                    }
                    if (firstCar.Model == secondCar.Model)
                    {
                        Console.WriteLine("Please select another car!!");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Please select Driver for the 2st car: \n 1) Bob \n 2) Greg \n 3) Jill \n 4) Anne");
                    string secondInputDriver = Console.ReadLine();

                    switch (secondInputDriver.ToLower())
                    {
                        case "bob":
                            secondDriver.Name = "Bob";
                            secondDriver.Skill = 10;
                            break;
                        case "greg":
                            secondDriver.Name = "Greg";
                            secondDriver.Skill = 6;
                            break;
                        case "jill":
                            secondDriver.Name = "Jill";
                            secondDriver.Skill = 3;
                            break;
                        case "anne":
                            secondDriver.Name = "Anne";
                            secondDriver.Skill = 8;
                            break;
                        default:
                            Console.WriteLine("Please select Driver");
                            continue;
                    }
                    break;
                }

                RaceCars(firstCar, secondCar, firstDriver, secondDriver);

                Console.WriteLine("Do you want another race y/n?");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
                
            }

           
            
                
                
            
            
            



        }
    }
}

using System;

namespace Exercise3
{
    internal class Program
    {
        public static Customer FindCustomer(Customer[] customers, string cardNumber)
        {
            foreach(Customer customer in customers)
            {
                if(customer.CardNumber == cardNumber)
                {
                    return customer;
                }
            }
            return null;
        }
        public static void UserInterface(Customer customer)
        {
            Console.WriteLine("What would you like to do: \n a.Check Balance \n b.Cash Withdrawal \n c.Cash Deposit");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "a":
                    customer.GetAccountBalance();
                    break;
                case "b":
                    Console.WriteLine("How much money you like to withdraw?");
                    string withdrawal =  Console.ReadLine();
                    if (int.TryParse(withdrawal, out int money))
                    {
                        if (!customer.MakeWithdrawal(money))
                        {
                            Console.WriteLine("You dont have enaugh money for this withrawal");
                        }
                        else
                        {
                            Console.WriteLine($"You withdrew {money}");
                            customer.GetAccountBalance();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter number");
                    }
                    break;
                case "c":
                    Console.WriteLine("How much money you like to deposit:");
                    string deposit = Console.ReadLine();
                    if (int.TryParse(deposit, out int moneyDeposit))
                    {
                        customer.MakeDeposit(moneyDeposit);
                        Console.WriteLine($"You have deposited {moneyDeposit}");
                        customer.GetAccountBalance();
                    }
                    else
                    {
                        Console.WriteLine("Please enter number");
                    }
                    break;
                default:
                    Console.WriteLine("Please select again");
                    break;
            }
        }
        public static void Register(Customer[] customers, string firstName, string lastName, string cardNumber, int pin, double balance)
        {
            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = new Customer(firstName, lastName, cardNumber, pin, balance);

            Console.WriteLine("Successfully registered new User!");

            foreach (Customer c in customers)
            {
                Console.WriteLine(c.FirstName);
            }
        }

        static void Main(string[] args)
        {
            
            Customer[] customers = new Customer[]
            {
                new Customer("Bob", "Bobsky", "1234123412341234", 1234, 750),
                new Customer("Jill", "Wayne", "1234123412341232", 1244, 1750),
                new Customer("John", "Smith", "1234123412341222", 1334, 2750),
                new Customer("Anne", "May", "1234123412341555", 1234, 250),
            };
            

            Console.WriteLine("If you want to register press r.");
            string a = Console.ReadLine();
            if (a == "r")
            {
                Console.WriteLine("Enter first Name");
                string fName = Console.ReadLine();

                Console.WriteLine("Enter last Name");
                string lName = Console.ReadLine();

                Console.WriteLine("Enter card number");
                string cNumber = Console.ReadLine();

                Console.WriteLine("Enter pin");
                bool q = int.TryParse(Console.ReadLine(), out int pPPin);

                Console.WriteLine("Enter balance");
                bool qq = double.TryParse(Console.ReadLine(), out double bBalance);

                
                Register(customers, fName, lName, cNumber, pPPin, bBalance);
                
            }
            else
            
            Console.WriteLine("Welcome to our ATM");
            Console.WriteLine("Enter card number");

            string cardNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(cardNumber))
            {
                Console.WriteLine("You must enter the card number");
            }
            else
            {
                Customer customer = FindCustomer(customers, cardNumber);

                if (customer == null)
                {
                    Console.WriteLine("Customer not found");
                    return;
                }

                Console.WriteLine("Enter pin");
                bool success = int.TryParse(Console.ReadLine(), out int pin);

                if (success)
                {
                    if (customer.CheckPin(pin))
                    {
                        Console.WriteLine($"Hi {customer.FullName}");
                        UserInterface(customer);
                        Console.WriteLine("Thank you for using the ATM app");

                        Console.WriteLine("Do you want to make new transaction y/n?");
                        string ans = Console.ReadLine();

                        if (ans.ToLower() == "y")
                        {
                            Console.Clear();
                            UserInterface(customer);
                        }
                        else
                        {
                            Console.WriteLine("Goodbye");
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter pin");
                    return;
                }
                
            }
        }
    }
}

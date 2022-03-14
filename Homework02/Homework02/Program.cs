using System;

namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert number1");
            string input = Console.ReadLine();
            int.TryParse(input, out int number);

            Console.WriteLine("Please insert number2");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out int number2);

            Console.WriteLine("Please insert operation:");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(number + number2);
                    break;
                case "-":   
                    Console.WriteLine(number - number2);
                    break;
                case "*":
                    Console.WriteLine(number * number2);
                    break;
                case "/":
                    Console.WriteLine(number / number2);
                    break;
                
            }
            










        }
    }
}

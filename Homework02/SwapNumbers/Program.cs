using System;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert number1");
            string input1 = Console.ReadLine();
            int.TryParse(input1, out int number2);

            Console.WriteLine("Please insert number2");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out int number1);

            Console.WriteLine("First number is: " + number1);
            Console.WriteLine("Second number is: " + number2);









        }
    }
}

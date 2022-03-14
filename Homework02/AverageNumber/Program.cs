using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert number1");
            string input1 = Console.ReadLine();
            int.TryParse(input1, out int number1);

            Console.WriteLine("Please insert number2");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out int number2);

            Console.WriteLine("Please insert number3");
            string input3 = Console.ReadLine();
            int.TryParse(input3, out int number3);

            Console.WriteLine("Please insert number4");
            string input4 = Console.ReadLine();
            int.TryParse(input4, out int number4);

            int sum = number1 + number2 + number3 + number4;
            int average = sum / 4;
            Console.WriteLine(average);





        }
    }
}

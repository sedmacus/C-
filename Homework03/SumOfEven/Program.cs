using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];

            for (int i = 0; i < 6; i++)
            {
                while (true)
                {
                    Console.WriteLine("Please insert number " + (i + 1));
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine("Please insert number!");
                        continue;
                    }
                    else
                    {
                        array[i] = number;
                        break;
                    }
                }
            }
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of all even numbers is: " + sum);
        }
    }
}

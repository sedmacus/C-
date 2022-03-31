using System;
using System.Collections.Generic;

namespace HomeworkClass08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            while (true)
            {
                Console.WriteLine("Please insert number");
                
                if(int.TryParse(Console.ReadLine(), out int number))
                {
                    numbers.Enqueue(number);
                }
                else
                {
                    Console.WriteLine("This is not a number!");
                }

                Console.WriteLine("Do you want to enter another number Y/N");
                string input = Console.ReadLine();

                if(input.ToLower() != "y")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }

            foreach(int i in numbers)
            {
                Console.WriteLine($"You entered: {i}");
            }
        }
    }
}

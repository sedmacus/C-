using System;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentsG2 = new string[5] { "Pavel", "Vladimir", "Martin", "Vesna", "Nikola" };

            while (true)
            {
                Console.WriteLine("Please enter student group 1 or 2:");
                string input = Console.ReadLine();
                int.TryParse(input, out int number);

                if (number == 1)
                {
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                }
                else if (number == 2)
                {
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
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

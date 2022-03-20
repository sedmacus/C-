using System;

namespace Homework04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your birthday (mm/dd/yyyy)");
                string input = Console.ReadLine();
                if (input.Length != 10)
                {
                    continue;
                }
                else
                {
                    AgeCalculator(input);
                    break;
                }
            }
        }
        public static void AgeCalculator(string birthday)
        {
            DateTime today = DateTime.Today;

            string[] val = new string[3];

            val[0] = birthday.Substring(0, 2);
            val[1] = birthday.Substring(3, 2);
            val[2] = birthday.Substring(6, 4);

            Int32.TryParse(val[0], out int birthdayMonth);
            Int32.TryParse(val[1], out int birthdayDay);
            Int32.TryParse(val[2], out int birthdayYear);

            int todayDay = today.Day;
            int todayMonth = today.Month;
            int todayYear = today.Year;

            if (birthdayDay > todayDay)
            {
                todayMonth--;
            }

            if (birthdayMonth > todayMonth)
            {
                todayYear--;
            }

            int year = todayYear - birthdayYear;

            if (birthdayDay == todayDay && birthdayMonth == todayMonth)
            {
                Console.WriteLine("You are: " + year + " years old");
                Console.WriteLine("Happy Birthday!!!!");
            }
            else if (birthdayDay - todayDay == -1 && birthdayMonth == todayMonth)
            {
                Console.WriteLine("You are: " + year + " years old");
                Console.WriteLine("Yesterday was your birthday!!");
            }
            else if (birthdayDay - todayDay == 1 && birthdayMonth == todayMonth)
            {
                Console.WriteLine("You are: " + year + " years old");
                Console.WriteLine("Tomorrow is your birthday!!");
            }
            else
            {
                Console.WriteLine("You are: " + year + " years old");
            }

        }
    }
}

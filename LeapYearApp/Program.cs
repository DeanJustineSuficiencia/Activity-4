using System;

namespace LeapYearApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        static bool IsLeapYear(int year)
        {
            // Check if a year is a leap year
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
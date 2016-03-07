using System;
    class LeapYear
{
        static void Main()
        {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Year is leap: {0}",isLeap);

        Console.ReadLine();
        }
    }


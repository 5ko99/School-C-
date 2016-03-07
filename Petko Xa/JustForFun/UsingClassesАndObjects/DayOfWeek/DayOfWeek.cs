using System;
class DayOfWeek
{
    static void Main()
    {
        DateTime clockinfo = DateTime.Now;
        string day = clockinfo.DayOfWeek.ToString();
        Console.WriteLine("Today is {0}.",day);

        Console.ReadLine();
    }
}


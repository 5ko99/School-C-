using System;
class Workdays
{
    static void Main()
    {
        Console.Write("Enter year:");
        string year = Console.ReadLine();
        Console.Write("Enter mounth:");
        string mounth =Console.ReadLine();
        Console.Write("Enter day:");
        string day = Console.ReadLine();
        int count = 0;
        DateTime dayofWeek = DateTime.Now;
        while (true)
        {
            string dayofWeaektString = dayofWeek.DayOfWeek.ToString();
            if ( (dayofWeaektString == "Saturday") || (dayofWeaektString == "Sunday"))
            {
                
            }
            else
            {
                count++;
            }
            dayofWeek = dayofWeek.AddDays(1);
            if ((dayofWeek.Year.ToString() ==  year) && (dayofWeek.Month.ToString() == mounth) && (dayofWeek.Day.ToString() == day))
            {
                break;
            }
            
        }
        Console.WriteLine("Workdays from today to {0}.{1}.{2} are: {3}",day,mounth,year,count);
        Console.ReadLine();
    }
}


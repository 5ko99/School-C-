using System;
using System.Threading;
using System.Globalization;
class ConsoleReadLine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine(a * 10);
        Console.ReadKey();

    }
}

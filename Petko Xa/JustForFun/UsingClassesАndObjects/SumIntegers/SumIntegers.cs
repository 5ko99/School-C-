using System;
using System.Collections.Generic;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Whire a sequence of positive integer nummber separeted by space!");
        string numbers = Console.ReadLine();
        int sum = SumOfSequence(numbers);
        Console.WriteLine("Sum of this sequence is: {0}",sum);
        Console.ReadLine();
    }


    static int SumOfSequence(string numbers)
    {
        numbers = numbers + " ";
        int sum = 0;
        string n = "";
        List<int> num = new List<int>();
        foreach (char item in numbers)
        {
                if (char.IsNumber(item))
            {
                n = n + item;
                continue;
            }
                if (item == ' ')
            {
                num.Add(int.Parse(n));
                n = "";
            }        
        }
        foreach (int item in num)
        {
            sum += item;
        }
        return sum;
    }
}


using System;
using System.Text;
class RandomPasswordGenerator
{
    static Random generator = new Random();
    static void InserRandomSymbols(int count,StringBuilder password,string symbols)
    {
        for (int i = 0; i < count; i++)
        {
            char symbol = symbols[generator.Next(0, symbols.Length)];
            password.Insert(generator.Next(0, password.Length), symbol);
        }
    }

    static void Main()
    {
        string capitawLeters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerLeters = capitawLeters.ToLower();
        string digits = "0123456789";
        string specialSymbols = "!@#$%^&|*()_-+=<>{}[]";
        string allSymbols = capitawLeters + lowerLeters + digits + specialSymbols;    
        StringBuilder password = new StringBuilder();

        InserRandomSymbols(2, password, capitawLeters);
        InserRandomSymbols(2, password, lowerLeters);
        InserRandomSymbols(1, password, digits);
        InserRandomSymbols(3, password, specialSymbols);
        InserRandomSymbols(generator.Next(0, 7), password, allSymbols);

        Console.WriteLine("Your Random Password is: {0}", password.ToString());
        Console.ReadLine();
    }
}


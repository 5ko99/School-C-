using System;

class Hello
{
    static void Main()
    {
        int n = 2;
       Console.WriteLine("Hello C#");
       Console.WriteLine(n);
        for (int i = 0; i < 100; i++)
        {
            if (n > 0)
            {
                n += 1;
                n *= -1;
            }
            else
            {
                n *= -1;
                n += 1;
            }
            Console.WriteLine(n+"\r");
        }
       Console.ReadLine();
    }
}


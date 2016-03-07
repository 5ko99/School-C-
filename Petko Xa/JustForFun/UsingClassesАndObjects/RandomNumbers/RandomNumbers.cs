using System;
class RandomNumbers
{
    static void Main()
    {
        Random generator =  new Random();
        
        for (int i = 0; i < 10; i++)
        {
            int randomNummber = generator.Next(100, 201);
            Console.WriteLine(randomNummber);
        }

        Console.ReadLine();
    }
}


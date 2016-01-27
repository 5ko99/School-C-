using System;
class NumeralSystems
{
    static void Main()
    {
        byte[] BinNummber = new byte[16];
        Console.Write("From which type nummber you want to convert 2, 10, 16: ");
        byte index = byte.Parse(Console.ReadLine());
        if (index == 10)
        {
            Console.WriteLine("Enter decimal positively Integer and program will convert it!");
            Console.Write("n=");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Your nummber in binary is: {0}",DecimalToBinary.Convert(n));
            Console.WriteLine("Your nummber in hexadecimal is: {0}",DecimalToHexidemical.Convert(n));

        }

        if (index == 2)
        {
            Console.WriteLine("Enter binary positively Integer and program will convert it!");
            for (int i = 0; i < 15; i++)
            {
                Console.Write("n[{0}]=",i);
                BinNummber[i] = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your nummber in decimal is: {0}",BinaryToDecimal.Convert(BinNummber));
            Console.WriteLine("Your nummber in hexmila is: {0}" );

        }

            Console.ReadLine();
    }
}


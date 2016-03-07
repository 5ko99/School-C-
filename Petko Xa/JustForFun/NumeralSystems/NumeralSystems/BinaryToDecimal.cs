using System;

class BinaryToDecimal
{
    public static double Convert(byte[] n)
    {
        double decimalNummber = 0;
        for (int i = 0; i < n.Length; i++)
        {
            decimalNummber = n[i] *  Math.Pow(2.0, i);
        }
        return decimalNummber;
    }
}


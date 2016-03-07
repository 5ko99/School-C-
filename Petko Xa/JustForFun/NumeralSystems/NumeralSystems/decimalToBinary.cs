using System;
using System.Text.RegularExpressions;

class DecimalToBinary
{
    public static string Convert(uint n)
    {
        uint bin = 0;
        string binNum = "";    
        while (n != 0)
        {
            bin = n % 2;
            binNum = binNum + bin.ToString();
            bin = 0;
            n /= 2;            
        }
        return binNum;
    }
}


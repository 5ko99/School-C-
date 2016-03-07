using System;
class DecimalToHexidemical
{
    public static string Convert(uint n)
    {
        uint bin = 0;
        string binNum = "";
        while (n != 0)
        {
            bin = n % 16;
            if (bin>9)
            {
                if (bin==10)
                {
                    binNum = binNum + 'A';
                    bin = 0;
                    n /= 16;
                    continue;
                }
                if (bin == 11)
                {
                    binNum = binNum + 'B';
                    bin = 0;
                    n /= 16;
                    continue;
                }
                if (bin == 12)
                {
                    binNum = binNum + 'C';
                    bin = 0;
                    n /= 16;
                    continue;
                }
                if (bin == 13)
                {
                    binNum = binNum + 'D';
                    bin = 0;
                    n /= 16;
                    continue;
                }
                if (bin == 14)
                {
                    binNum = binNum + 'E';
                    bin = 0;
                    n /= 16;
                    continue;
                }
                if (bin == 15)
                {
                    binNum = binNum + 'F';
                    bin = 0;
                    n /= 16;
                    continue;
                }

            }
            else
            {
                binNum = binNum + bin.ToString();
                bin = 0;
                n /= 16;
            }
            
        }
        return binNum;
    }
}


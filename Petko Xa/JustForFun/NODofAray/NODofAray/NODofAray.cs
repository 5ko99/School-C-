using System;
class NODofAray
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        int min = arr[0];
        int nod = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= min; j++)
            {
                if (arr[i] % j == 0)
                {
                    nod = j;
                }
            }

        }
        Console.WriteLine("NOD={0}", nod);
        Console.ReadLine();
    }
}


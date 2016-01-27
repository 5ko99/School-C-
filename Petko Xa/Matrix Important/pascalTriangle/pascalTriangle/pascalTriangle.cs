using System;

class pascalTriangle
{
    static void Main()
    {
        Console.Write("Enter height:");
        int height = int.Parse(Console.ReadLine());
        int[][] triangle = new int[height][];
        triangle[0] = new int[1];
        triangle[0][0] = 1;

        for (int row = 1; row < height; row++)
        {
            triangle[row] = new int[row + 1];
            triangle[row][0] = 1;

            for (int col = 1; col < row; col++)
            {
                triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
            }

            triangle[row][row] = 1;

        }

        //Извеждаме масива
        int count = 18;
        for (int row = 0; row < triangle.Length; row++)
        {
            Console.Write("".PadLeft(count));
            for (int col = 0; col < triangle[row].Length; col++)
            {
                Console.Write("{0,3} ", triangle[row][col]);
            }
            Console.WriteLine();
            count -= 2;
        }

        Console.ReadLine();
    }
}

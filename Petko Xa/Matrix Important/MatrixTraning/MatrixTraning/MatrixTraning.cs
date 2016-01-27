using System;
class MatrixTraning
{
    static void Main()
    {
        //Правим си променлива флаг с която следим за грешки във въвеждането и ако има грешка не го извеждаме защото ще изведем грешен масив!
        bool flag = false;

        //Записваме броя на редовете
        Console.Write("Rows: ");
        int rows = int.Parse(Console.ReadLine());

        //Записваме броя на колоните
        Console.Write("Cols: ");
        int cols = int.Parse(Console.ReadLine());

        //Правим си двумерен масив с големината на редовете и колоните
        int[,] nummbers = new int [rows, cols];

        //Записване на Матрица ред по ред! ПРИМЕР : първи ред подаваме 123 втори 568 и т.н.
        for (int row = 0; row < rows; row++)
        {
            Console.Write("Enter {0}-th row: ",row);
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (currentRow.Length<cols)
            {
                Console.WriteLine("Error!");
                flag = true;
                break;
            }
            for (int col = 0; col < cols; col++)
            {
                nummbers[row, col] = int.Parse(currentRow[col]);
            }
        }

        // Ако flag e == false просто извеждаме масива но ако е true не го извеждаме
        if (flag==false)
        {
            //Извеждаме масива в табличен вид
            Console.WriteLine();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0,5}",nummbers[row, col]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //Задържаме края на програмата докато не се натисне ENTER
        Console.WriteLine("\n");
        Console.Write("Pres 'Enter' to exit!");
        Console.ReadLine();
    }
}


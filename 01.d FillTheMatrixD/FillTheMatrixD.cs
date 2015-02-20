using System;

//d)
//1	 12	11	10 
//2	 13	16	9  
//3	 14	15	8  
//4	 5	6	7  
class FillTheMatrixD
{
    static void Main()
    {
        Console.Write(@"Enter ""n"":");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int row = 0;
        int col = 0;
        int number = 1;
        int lastRow = 1;
        int lastCol = 1;
        while (number <= n * n)
        {
            if (col == lastCol - 1 && row == lastRow - 1)
            {
                while (row < n)
                {
                    array[row, col] = number++;
                    if (row == n - lastRow)
                    {
                        col++;
                        break;
                    }
                    row++;
                }
            }
            else if (row == n - lastRow && col == lastCol)
            {
                while (col < n)
                {
                    array[row, col] = number++;
                    if (col == n - lastCol)
                    {
                        row--;
                        break;
                    }
                    col++;
                }
            }
            else if (col == n - lastCol && row == n - lastRow - 1)
            {
                while (row >= lastRow - 1)
                {
                    array[row, col] = number++;
                    if (row == lastRow - 1)
                    {
                        break;
                    }
                    row--;
                }
            }
            else if (row == lastRow - 1 && col == n - lastCol)
            {
                col--;
                while (col >= lastCol)
                {
                    array[row, col] = number++;
                    if (col == lastCol)
                    {
                        lastRow++;
                        lastCol++;
                        row++;
                        break;
                    }
                    col--;
                }
            }
        }

        for (row = 0; row < n; row++)
        {
            for (col = 0; col < n; col++)
            {
                Console.Write("{0,-2} ", array[row, col]);
            }
            Console.WriteLine();
        }
    }
}
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write(@"Enter ""n"" for number of rows (n>2): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(@"Enter ""m"" for number of columns (m>2): ");
        int m = int.Parse(Console.ReadLine());
        int[,] array = new int[n, m];
        int sum = 0;
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine("***Row {0}: ", row);
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter number of position {0},{1}: ", row, col);
                array[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Your matrix is:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0,-2} ", array[row, col]);
            }
            Console.WriteLine();
        }

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                sum = array[row, col] + array[row, col + 1] + array[row, col + 2]
                    + array[row + 1, col] + array[row + 1, col + 1] + array[row + 1, col + 2]
                    + array[row + 2, col] + array[row + 2, col + 1] + array[row + 2, col + 2];
                if (bestSum < sum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("\nThe biggest sum is {0}.\nThe square with that sum is:", bestSum);
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write("{0} ", array[row, col]);
            }
            Console.WriteLine();
        }

    }
}
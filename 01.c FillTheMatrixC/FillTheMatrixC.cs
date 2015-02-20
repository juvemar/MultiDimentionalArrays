using System;

//c)
//7	 11	14	16
//4	 8	12	15
//2	 5	9	13
//1	 3	6	10
class FillTheMatrixC
{
    static void Main()
    {
        Console.Write(@"Enter ""n"":");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int number = 1;
        int row = 0;
        int col = 0;

        for (int i = n - 1; i >= 0; i--)//filling matrix under the diagonal
        {
            row = i;
            col = 0;
            while (row < n && col < n)
            {
                array[row++, col++] = number++;
            }
        }

        for (int i = 1; i < n; i++)
        {
            row = 0;
            col = i;
            while (row < n && col < n)
            {
                array[row++, col++] = number++;
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
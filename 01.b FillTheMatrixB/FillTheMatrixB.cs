using System;

//b)
//1	 8	9	16
//2  7	10	15
//3	 6	11	14
//4	 5	12	13

class FillTheMatrixB
{
    static void Main()
    {
        Console.Write(@"Enter ""n"":");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int column = 0;
        int number = 1;
        bool breaker = true;

        for (int row = 0; row < n; row++)
        {
            if (breaker)
            {
                array[row, column] = number;
                if (number == n * n)
                {
                    break;
                }
                number++;
                if (row == n - 1)
                {
                    column++;
                    for (row = n - 1; row >= 0; row--)
                    {
                        array[row, column] = number;
                        if (number == n * n)
                        {
                            breaker = false;
                        }
                        number++;
                        if (row == 0)
                        {
                            column++;
                        }
                    }
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,-2} ", array[row, col]);
            }
            Console.WriteLine();
        }
    }
}
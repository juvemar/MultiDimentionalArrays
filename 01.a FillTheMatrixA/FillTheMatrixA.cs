//Write a program that fills and prints a matrix of size (n, n).﻿

using System;

//a)
//1	 5	9	13   
//2	 6	10	14
//3	 7	11	15
//4	 8	12	16
class FillTheMatrixA
{
    static void Main()
    {
        Console.Write(@"Enter ""n"":");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int counter = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                array[row, col] = counter++;
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
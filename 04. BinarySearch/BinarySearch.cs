//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method 
//Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Linq;
class BinarySearch
{
    static void Main()
    {
        Console.Write(@"Enter ""k"": ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter the integers(separated by space): ");
        string numbers = Console.ReadLine();
        string[] separateNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] intArray = separateNumbers.Select(x => int.Parse(x)).ToArray();
        Array.Sort(intArray);

        string sorted = string.Join(", ", intArray);
        Console.WriteLine("The array after the sorting is: {0}", sorted);

        if (intArray[0] > k)
        {
            Console.WriteLine(@"There are no numbers less or equal to ""k"".");
        }
        else
        {
            int largest = Array.BinarySearch(intArray, k);
            if (largest < 0)
            {
                Console.WriteLine(@"The largest number less or equal to {0} is {1}.", k, intArray[-largest - 2]);
            }
            else Console.WriteLine(@"The largest number less or equal to {0} is {1}.", k, intArray[largest]);
        }
    }
}
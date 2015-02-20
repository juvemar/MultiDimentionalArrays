//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
class SortByStringLength
{
    static void Main()
    {
        string[] array = { "ss", "sa", "dsfs", "haho", "hihuha", "b", "dada" };
        
        var result = array
            .OrderBy(s => s.Length)//sort by length
            .ThenBy(s=> s);//if strings have same length, sort them alphabetically

        foreach (string sorted in result)
        {
            Console.WriteLine(sorted);
        }
    }
}

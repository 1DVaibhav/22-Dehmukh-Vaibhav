using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Data Source: A list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Query Creation: Using LINQ query syntax
        var query = from number in numbers
                    where number % 2 == 0
                    select number;

        // Query Execution: Iterating through the results and displaying them
        Console.WriteLine("Even numbers:");
        foreach (var result in query)
        {
            Console.Write(result + " ");
        }

        Console.ReadKey();
    }
}

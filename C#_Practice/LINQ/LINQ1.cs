using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.LINQ
{
    internal class LINQ1

    // Write a C# LINQ query to:
    // Select only numbers greater than 10.
    // Sort the selected numbers in ascending order.
    // Print each result using foreach.

    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 5, 25, 8, 30, 15, 40, 3 };

            var result = numbers
                .Where(number => number > 10)
                .OrderBy(number => number);

            foreach( var number in result)
            {
                Console.WriteLine(number);
            }
        }
        
    }
}

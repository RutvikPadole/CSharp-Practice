using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.LINQ
{
    internal class Exercies5

    // Combine all three operators
    // Filter numbers greater than 10.
    // Sort the remaining numbers in ascending order.
    // Multiply each remaining number by 2.
    // Print the results using foreach.
    {

        static void Main(string[] args)
        {
            int[] numbers = { 9, 4, 16, 7, 20, 12, 3, 25 };

            var result = numbers
                .Where(number => number > 10)
                .OrderBy(number => number)
                .Select(number => number * 2);

            foreach ( var number in result )
            {
                Console.WriteLine(number);
            }
        }
    }
}

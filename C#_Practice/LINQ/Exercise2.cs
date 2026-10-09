using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.LINQ
{
    internal class Exercise2

    // Select numbers greater than 10.
    // Sort them in descending order.
    // Print each number using foreach.
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 18, 7, 22, 10, 35, 14, 2 };

            var result = numbers
                .Where(number => number > 10)
                .OrderByDescending(number => number);

            foreach ( var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}

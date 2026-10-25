using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.LINQ
{
    internal class Any1

    // Use Any() to check whether at least one number is greater than 20, then print the result.
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 18, 25, 30 };

            var result = numbers
                .Any(number => number > 20);

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class Linq
    {
        static void Main()
        {
            int[] numbers = { 2, 5, 8, 11, 14, 17 };

            var result = numbers
                        .Where(n => n % 2 == 0)
                        .Select(n => n * 5);

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

        }
    }
}

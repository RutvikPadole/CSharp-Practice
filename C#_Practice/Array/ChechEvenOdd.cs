using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace C__Practice.Array
{
    internal class ChechEvenOdd
    {
        // Count Even and Odd Numbers in an Array.

        static void Main()
        {
            int[] arr = { 10, 15, 22, 7, 8, 13, 20 };

            int even = 0;
            int odd = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] % 2 == 0)

                    even++;
                else 
                    odd++;

            }
            Console.WriteLine("Even number is :- " + even);
            Console.WriteLine("Odd number is :- " + odd);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class FindSum
    {
        // Find the Sum of All Elements in an Array.
        static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50};

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("The total sum of number is :- " +  sum);
        }
    }
}

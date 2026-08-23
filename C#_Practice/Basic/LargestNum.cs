using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class LargestNum
    {
        // Write a C# program to find the largest number in an array.

        static void Main()
        {
            int[] arr = { 10, 50, 60, 98, 30, 40 };

            int largest = arr[0];

            for (int i=1;  i<arr.Length; i++)
            {
                if (arr[i]> largest)
                {
                    largest = arr[i];
                }
            }

            Console.WriteLine("Largest number is :- " + largest);

        }
    }
}

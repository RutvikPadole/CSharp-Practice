using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class CountNumber
    {
        static void Main(string[] args)
        {
            // Count Numbers Greater Than Average

            int[] arr = { 10, 20, 30, 40, 50 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }

            int avg = sum / arr.Length;

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > avg)

                count++;
            }

            Console.WriteLine("Average of numbers :- " + avg);
            Console.WriteLine("Number greater than average :- " + count);

        }


    }
}

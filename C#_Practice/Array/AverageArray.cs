using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class AverageArray
    {
        static void Main(string[] args)
        {
            // Find the Average of Array Elements

            int[] arr = { 10, 20, 30, 40, 50 };

            int avg = 0;
            int sum = 0;
          

            for (int i = 0; i < arr.Length; i++)
            {
               sum = sum + arr[i];

                avg = sum / arr.Length;
            }

            Console.WriteLine("Average of array element is :- " + avg);
        }
    }
}

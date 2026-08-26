using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class CheckEvenOdd2
    {
        // print the actual even and odd numbers using array.
        static void Main(string[] args)
        {
            int[] arr = { 10, 15, 22, 7, 8, 13, 20 };

            for (int i = 1; i<= arr.Length; i++)
            {

                if (arr[i] % 2==0)
                {
                    Console.WriteLine(arr[i] +  " is even");
                }
                else
                {
                    Console.WriteLine(arr[i]  +  " is Odd");
                }
            }

        }
    }
}

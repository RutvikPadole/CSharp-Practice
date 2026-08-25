using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class ReverseArray
    {
        // Write a C# program to reverse this array:
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int i = arr.Length -1; i>= 0; i--)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}

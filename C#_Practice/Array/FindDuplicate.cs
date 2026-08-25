using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class FindDuplicate
    {
        static void Main()
        {
            // Find Duplicate Elements in an Array

            int[] arr = { 10, 20, 30, 20, 40, 10, 50, 100, 150, 50, 30, 150 };

            for (int i =0; i <arr.Length;i++)
            {
                for (int j=i+1; j< arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicate number is :- " + arr[i] , arr[j]);
                   
                    }
                }
            }
        }
    }
}

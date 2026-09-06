using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class SecondSmallest
    {
        static void Main(string[] args)
        {
            // Task 20 — Find the Second Smallest Number

            int[] arr = { 10, 5, 20, 3, 8, 15 };

            int smallest = arr[0];
            int secondsmallest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondsmallest = smallest;
                    smallest = arr[i];
                }

                else if (arr[i] < secondsmallest)
                {
                    secondsmallest = arr[i];
                }

            }

            Console.WriteLine("Smallest Number is :- " + smallest);
            Console.WriteLine("SecondSmallest Number is :- " + secondsmallest);
        }
    }
}

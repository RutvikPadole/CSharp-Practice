using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class SecondLarge
    {
        static void Main()
        {
            int[] arr = { 10, 20, 35, 63, 90, 56 };

            int largest = arr[0];
            int secondlargest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondlargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondlargest)
                {
                    secondlargest = arr[i];
                }

                Console.WriteLine("largest number is :- " + largest);
                Console.WriteLine("Second largest number is :- " + secondlargest);
            }
        }
    }
}

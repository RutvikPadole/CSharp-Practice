using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class FrequencyOfNum
    {

        // Write a C# program to find how many times a particular number appears in an array.
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 10, 30, 10, 40, 20, 50 };

            int count = 0;

            for (int i=0; i <arr.Length; i++)
            {
                if (arr[i] == 10)
                {
                    count++;
                }
            }

            Console.WriteLine("The Frequency of number is :- " + count);
            }
        }
    
}

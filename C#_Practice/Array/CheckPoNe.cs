using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace C__Practice.Array
{
    internal class CheckPoNe
    {
        // Print actual positive and negative number.

        static void Main(string[] args)
        {
            int[] arr = { 10, -5, 20, -8, 0, 15, -3 };


            for (int i=0; i< arr.Length; i++)
            {
                if (arr[i] >0)
                {
                    Console.WriteLine(arr[i] + " is positive");
                }

                else if (arr[i] <0)
                {
                    Console.WriteLine(arr[i] + " is negative");
                }

                else if (arr[i] ==0)
                {
                    Console.WriteLine(arr[i] + " is zero");
                }
                    
            }
        }
    }
}

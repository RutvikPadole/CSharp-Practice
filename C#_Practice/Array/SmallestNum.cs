using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace C__Practice.Array
{
    internal class SmallestNum
    {
        //Find the Smallest Number in an Array
        static void Main(string[] args)
        {
            int[] arr = { 10, 5, 36, 20, 1, 35, 98, 65, 20 };

            int smallest = arr[0];
       
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]< smallest)
                {
                    smallest = arr[i];
                 
                }

            }

            Console.WriteLine("Smallest number is :- " + smallest);


        }
    }
}

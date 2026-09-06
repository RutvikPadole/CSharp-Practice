using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class FindEven
    {
        static void Main(string[] args)
        {
            // Find the Sum of Even Numbers in an Array 

            int[] arr = { 10, 15, 20, 25, 30, 35, 40 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {

                    Console.WriteLine("Even number is :- " + arr[i]);

                    sum = sum + arr[i];
                }

            }

            Console.WriteLine("The sum of even number is :- " + sum);
        }

        }
    }


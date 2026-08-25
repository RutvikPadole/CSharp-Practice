using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    internal class CountPoNe
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, -5, 20, -8, 0, 15, -3 };

            int positive = 0;
            int negative = 0;
            int zero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive++;
                }
                else if (arr[i] < 0)
                {
                    negative++;
                }
                else if (arr[i] == 0)
                {
                    zero++;
                }
            }

            Console.WriteLine("Positive number is :- " + positive);
            Console.WriteLine("Negative number is :- " + negative);
            Console.WriteLine("Total zero is :- " + zero);

        }
    }
}

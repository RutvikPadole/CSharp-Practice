using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.ForLoop
{
    internal class SumLoop
    {
        // Calculate the sum of numbers from 1 to 100
        // (don't print each number, just print the final sum).
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i=1;i<=100;i++)
            {
                sum = sum + i;   
            }

            Console.WriteLine(sum);
        }

    }
}

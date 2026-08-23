using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class PrimeNumber
    {
        // Write a C# program to check whether a number is prime or not.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32 (Console.ReadLine());

            int count = 0;
            
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)

                    count++;
            }

            if (count == 2)
                Console.WriteLine("Prime number");
            else
                Console.WriteLine("Not prime number");

        }
    }
}



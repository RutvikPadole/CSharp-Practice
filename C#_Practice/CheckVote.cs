using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class CheckVote
    {
        static void Main(string[] args)
        {
            // Given a person's int age, print whether they're eligible to vote (age >= 18) using a simple if condition.

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Person is eligible for vote");
            }
            else
            {
                Console.WriteLine("Person is not eligible for vote");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class Reverse
    {
        static void Main()
        {
            // WAP to reverse number

            Console.WriteLine("enter numbers");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            while (num > 0)
            {
                int digit = num % 10;
                result = result * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine("Reversed number : " + result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace C__Practice.Basic
{
    internal class CheckEvenTernary
    {
        static void Main()
        {
            // Check if a number is even or odd  using ternary operator.

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

           string result = num % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(result);
        }
          

    }
}

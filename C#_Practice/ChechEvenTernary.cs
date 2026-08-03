using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace C__Practice
{
    internal class ChechEvenTernary
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            string result;

            result = num % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(result);
        }
          

    }
}

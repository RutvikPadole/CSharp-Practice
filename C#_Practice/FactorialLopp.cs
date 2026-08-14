using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class FactorialLopp
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32 (Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <=num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}

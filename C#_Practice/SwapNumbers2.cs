using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class SwapNumbers2
    {
        static void Main(string[] args)
        {
            // Take two integers and swap their values without using a third variable.

            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping");
            Console.WriteLine("num1 : " + num1);
            Console.WriteLine("num2 : " + num2);

        }
    }
}

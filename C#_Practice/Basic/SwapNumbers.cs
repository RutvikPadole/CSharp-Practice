using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class SwapNumbers
    {
        static void Main(string[] args)
        {
            // WAP TO Swap two numbers ( WITH third variable )

            Console.WriteLine("Enter your first number");
            int num1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int num2 =Convert.ToInt32(Console.ReadLine());

            int temp = num1;

            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("num1 : " + num1);
            Console.WriteLine("num2 : " + num2);
        }
    }
}

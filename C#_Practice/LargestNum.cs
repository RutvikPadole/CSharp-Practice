using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace C__Practice
{
    internal class LargestNum
    {
        static void Main(string[] args)
        {
            // WAP TO Largest of 2 numbers  

            Console.WriteLine("Enter first number");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 =Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num1 is largest");
            }
          else if  (num2> num1)
            {
                Console.WriteLine("num2 is largest");
            }
           else
            {
                Console.WriteLine("Both numbers are equal");
            }
        }
    }
}

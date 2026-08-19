using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class CalWithSwith
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your operator");
            char op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("Result " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result " + (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("Result " + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("enter wrong operator");
                    break;

            }
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            // WAP for calculator 

            Console.WriteLine("Enter your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /):");
            char op = Convert.ToChar(Console.ReadLine());

            int result;

            switch(op)
            {
                case '+':
                    {
                        result = num1 + num2;
                        Console.WriteLine("result = " + result);
                    }
                    break;

                case '-':
                    {
                        result = num1 - num2;
                        Console.WriteLine("result = " + result);
                    }
                    break;

                case '*':
                    {
                        result = num1 * num2;
                        Console.WriteLine("result = " + result);
                    }
                    break;

                case '/':

                    if (num2==0)
                    {
                        Console.WriteLine("Cannot devided by zero");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("result = " + result);
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Invalid Operator");
                    }
                    break;

            }
        }
    }
}

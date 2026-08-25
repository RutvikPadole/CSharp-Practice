using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class Armstrong
    {
        static void Main()
        {
           // WAP to check Armstrong numbers

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int sum = 0;

            while (num>0)
            {
                int digit = num % 10;
               sum = sum + (digit * digit * digit);
                num  = num / 10;
            }   
            if (original == sum )
            {
                Console.WriteLine("The number is armstrong number");
            }
            else
            {
                Console.WriteLine("The number is not armsrong number");
            }
        }
    }
}

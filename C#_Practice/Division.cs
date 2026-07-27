using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class Division
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 5 == 0 && num % 11 ==0 )
            {
                Console.WriteLine("Number is devisible by both 5 and 11");
            }
            else
            {
                Console.WriteLine("Number is not devisible by both 5 and 11");
            }
         }
    }
}

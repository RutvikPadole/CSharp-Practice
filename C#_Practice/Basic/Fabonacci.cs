using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basic
{
    internal class Fabonacci
    {
        static void Main()
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(a+ " ");

                c = a + b;
                a = b;
                b = c;
            }

        }
    }
}

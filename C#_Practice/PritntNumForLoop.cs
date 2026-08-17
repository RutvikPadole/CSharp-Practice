using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class PritntNumForLoop
    {
        // Task B: Print numbers from 1 to 20,
        // but only print the multiples of 3 (3, 6, 9, 12...).
        static void Main()
        {
            for(int i = 1; i<=20;  i++)
            {
                if (i % 3 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

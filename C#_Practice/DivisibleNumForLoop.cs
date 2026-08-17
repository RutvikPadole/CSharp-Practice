using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class DivisibleNumForLoop
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count = count + 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}

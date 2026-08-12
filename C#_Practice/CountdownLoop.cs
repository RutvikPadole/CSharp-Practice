using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class CountdownLoop
    {
        //Print numbers from 10 down to 1 (countdown).

        static void Main(string[] args)
        {
            for(int i=10;  i>=1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

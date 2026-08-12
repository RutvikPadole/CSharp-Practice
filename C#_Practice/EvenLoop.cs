using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace C__Practice
{
    internal class EvenLoop
    {
        // Print all even numbers between 1 and 20.

        static void Main(string[] args)
        {
            for(int i=2; i<=20; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

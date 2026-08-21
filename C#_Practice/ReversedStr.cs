using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    internal class ReversedStr
    {
        static void Main()
        {
            Console.WriteLine("Enter string");
            string Input = Console.ReadLine();

            int length = Input.Length;
            Console.WriteLine("Length " + length);

            char[] chars = Input.ToCharArray();
            Array.Reverse(chars);

            string reversed = new string(chars);

            Console.WriteLine("Reversed : " + reversed);
                                        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Strings
{
    internal class RemoveDuplicate
    {
        static void Main()
        {
            //String Task 8 — Remove Duplicate Characters

            string str = "programming";
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result = result + str[i];
                }
            }

            Console.WriteLine("After removing duplicates: " + result);
        }
    }
}
        
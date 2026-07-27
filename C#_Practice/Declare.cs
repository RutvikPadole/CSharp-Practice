using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace C__Practice
{
    internal class Declare
    {
        static void Main(string[] args)
        {
            // Declare variables for your name, age, height (decimal), and whether you're a student (bool), then print them in one sentence using string interpolation.

            string name = "Rutvik";
            int age = 23;
            float height = 5.4f;
            bool isStudent = true;

            Console.WriteLine($"Name {name} age is {age} years old, height {height}, Student: {isStudent}");
        }
    }
}

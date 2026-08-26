using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.IfElse
{
    internal class StudentGrade
    {
        static void Main()
        {
            Console.WriteLine("Enter student marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            
            if (marks > 100 || marks < 0)
            {
                Console.WriteLine("Invalid input");
            }

            else if (marks >= 90)
            {
                Console.WriteLine("student pass with grade A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("student pass with grade B");
            }
            else if (marks >=60)
            {
                Console.WriteLine("student pass with grade C");
            }
            else if (marks >=40)
            {
                Console.WriteLine("student pass with grade D");
            }
            else
            {
                Console.WriteLine("Student is fail");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Demo
{
    internal class QuizzApp
    {
        static void Main(string[] args)
        {

            string Question1 = "What is the capital of germany";
            string Answer1 = "Berlin";

            string Question2 = "What is 2+2";
            string Answer2 = "4";

            string Question3 = "What color do you get by mixing blue and yellow";
            string Answer3 = "Green";

            int score = 0;

            Console.WriteLine(Question1);
            string UseAnswer1 = Console.ReadLine();

            if (UseAnswer1.Trim().ToLower() == Answer1.ToLower())
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else 
            {
                Console.WriteLine("Wrong the correct answer is : "+ Answer1);
            }


            Console.WriteLine(Question2);
            string UseAnswer2 = Console.ReadLine();

            if (UseAnswer2.Trim().ToLower() == Answer2.ToLower()) // Trim() removes extra spaces from the beginning and end of a string.
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine("Wrong the correct answer is : "+ Answer2);
            }


            Console.WriteLine(Question3);
            string UseAnswer3 = Console.ReadLine();

            if (UseAnswer3.Trim().ToLower() == Answer3.ToLower())
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine("Wrong the correct answer is : "+ Answer3);
            }

            Console.WriteLine($"Quizz Completed! Your final score is : { score} /3");

            if (score == 3)
            {
                Console.WriteLine("Excellent! You got all the answer right");
            }
            else if (score >0)
            {
                Console.WriteLine("Good job, but keep learning!");
            } 
            else
            {
                Console.WriteLine("Try again and see you can get some answers right next time ");
            }
        }

    }
}

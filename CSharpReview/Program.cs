using System;
using System.Collections.Generic;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
            List<int> intList = new List<int>();

            int userInput = 1;
            do
            {
                userInput = GetInt("Please enter a positive integer to add to the list, or a negative one to exit: ");
                if (userInput > 0)
                {
                    intList.Add(userInput);
                }
            } while (userInput > 0);

            foreach ( int i in intList)
            {
                Console.WriteLine(i);
            }
        }

        static int GetInt(string prompt)
        {
            int input;
            Console.Write(prompt);
            input = int.Parse(Console.ReadLine());
            return input;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        
        {
            List<string> stringList = new List<string>();

            string userInput = "default";
            do
            {
                userInput = GetName("Please enter a name to add to the list, or nothing (empty string) to exit: ");
                if (userInput != "")
                {
                    if (stringList.Contains(userInput))
                    {
                        Console.WriteLine("That's a duplicate entry! Please try again!");
                    } 
                    else
                    {
                        stringList.Add(userInput);
                    }                    
                }
            } while (userInput != "");

            foreach ( string name in stringList )
            {
                Console.WriteLine(name);
            }
        }

        static string GetName(string prompt)
        {
            string input;
            Console.Write(prompt);
            input = Console.ReadLine().Trim().ToLower();
            return input;
        }

        static int GetInt(string prompt)
        {
            int input = 0;
            bool valid = false;
            do
            {
                Console.Write(prompt);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (!valid);

            return input;
        }

    }
}

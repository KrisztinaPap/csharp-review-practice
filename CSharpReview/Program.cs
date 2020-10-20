using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            List<int> ageList = new List<int>();

            string userInputName = "";
            int userInputAge = 0;
            do
            {
                userInputName = GetName("Please enter a name OR 'exit' to quit the program: ");
                if ( userInputName != "exit" )
                {
                    nameList.Add(userInputName);
                    userInputAge = GetAge("Please enter an age between 1 and 100, inclusive: ");
                    ageList.Add(userInputAge);
                }
            } while (userInputName != "exit");

            for( int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine($"{nameList[i]} is {ageList[i]} years old.");
            }
        }

        static string GetName(string prompt)
        {
            Console.Write(prompt);

            return Console.ReadLine().Trim().ToLower();
        }

        static int GetAge(string prompt)
        {
            int input = 0;
            bool valid = false;
            do
            {
                Console.Write(prompt);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input < 1 || input > 100)
                    {
                        throw new Exception($"Please enter an age between 1 and 100, inclusive.");
                    }
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!valid);

            return input;
        }        
    }
}

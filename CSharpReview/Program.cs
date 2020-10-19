using System;
using System.Runtime.CompilerServices;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
            // Declaration of variables

            char aChar;
            string aString;

            bool aBoolean;

            byte aByte; // Super small integer values (~120 max)
            int anInt;
            short aShortInt;
            long aLongInt;

            float aFloat; // Less precise than double
            double aDouble;
            decimal aDecimal; // Extremely precise


            string name;

            // Write keeps the cursor on same line
            Console.Write("Please enter your name: ");

            name = Console.ReadLine().Trim();

            // Roughly equivalent to name == "", except it also treats null as empty, and any whitespace
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalud input: Please enter a name.");
            }
            else if (name.ToLower() == "admin")
            {
                Console.WriteLine("Administrative access granted.");
            }
            else
            {
                // Concatenation
                Console.WriteLine("Hello " + name + "! What a nice day!");
                // Parameterized output
                Console.WriteLine("Hello {0}! What a nice day today!", name);
                // String interpolation
                Console.WriteLine($"Hello {name}! What a nice day today!");
            }           
        }
    }
}

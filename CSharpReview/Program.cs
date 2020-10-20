using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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


            int userInput;
            string output;

            Console.Write("Please enter a number: ");

            userInput = int.Parse(Console.ReadLine());

            int y = 1;
            while (y <= userInput)
            {
                Console.WriteLine(y);
                y++;
            }

            for (int x = 1; x <= userInput; x++)
            {
                Console.WriteLine(x);
            }

            int z = 1;
            do
            {
                Console.WriteLine(z);
                z++;
            }
            while (z <= userInput);

            int[] intArray = new int[5];
            int[] intArrayFilled = new int[] { 3, 5, 7, 8 };

            bool[] boolArray = new bool[5];

            intArray[3] = 10;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
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

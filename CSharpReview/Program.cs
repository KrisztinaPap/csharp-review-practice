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


            int userInput;
            string output;

            Console.Write("Please enter a number: ");

            userInput = int.Parse(Console.ReadLine());

            int y = 1;
            while( y <= userInput )
            {
                Console.WriteLine(y);
                y++;
            }

            for( int x = 1; x <=userInput ; x++ )
            {
                Console.WriteLine(x);
            }

          
        }
    }
}

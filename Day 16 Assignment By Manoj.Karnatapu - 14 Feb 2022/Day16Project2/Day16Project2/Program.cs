using System;

// Author : Manoj.Karnatapu
// Purpose : Reading & Printing the Factorial of a Number, Using Object Oriented Approach.

// For Reference, Check Day16Project2 in the same Repository.

namespace Day16Project2
{
    class Factorial
    {
         int input;

        /// <summary>
        /// Reading Inputs to Calculate Factorial.
        /// </summary>
        /// <returns>Given Input value</returns>
        public int ReadInput()
        {
            Console.Write("\nEnter any Number To Calculate It's Factorial : ");
            input = int.Parse(Console.ReadLine());
            return input;
        }
        /// <summary>
        /// Returning the Factorial of a given Number, after calculation
        /// </summary>
        /// <returns>Factorial Calculated Value</returns>
        public int PrintFactorial()
        {
            int fact = 1;
            for(int i = 1; i <= input;i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            int input = factorial.ReadInput();
            Console.WriteLine("\nThe Factorial of {0} is  : {1}\n",input,factorial.PrintFactorial());

            Console.ReadKey();
        }
    }
}

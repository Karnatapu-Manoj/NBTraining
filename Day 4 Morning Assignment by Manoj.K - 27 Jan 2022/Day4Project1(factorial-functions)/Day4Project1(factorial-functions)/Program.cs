using System;

// This is A C# Code used to find the Factorial of Numbers By using Functions concept.
// Code Developed By Manoj Karnatapu - 27 Jan, 2022

namespace Day4Project1_factorial_functions_
{
    internal class Program
    {
        public static void PrintOutput(int n)
        {
            Console.WriteLine("Factorial of {0} = {1}",n, Factorial(n));
        }

        public static int Factorial(int n)
        {
            int fact = 1;

            for(int i = 1; i <= n;i++)
            {
                fact *= i;
            }

            return fact;
        }
        static void Main(string[] args)
        {
            int n = 4, n1 = 6, n2 = 3;

            PrintOutput(n);
            PrintOutput(n1);
            PrintOutput(n2);


            Console.ReadLine();
        }
    }
}

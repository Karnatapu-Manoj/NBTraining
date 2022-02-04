using System;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code for Single Inheritance

// For Reference, check Day10Project1 in the same Repository.

namespace Day10Project1
{
    class Algebra
    {
        /// <summary>
        /// This is a Addition Method of Two Numbers
        /// </summary>
        /// <param name="a">int A</param>
        /// <param name="b">int B</param>
        /// <returns>Sum</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// This is a Subtraction Method of Two Numbers
        /// </summary>
        /// <param name="a">int A</param>
        /// <param name="b">int B</param>
        /// <returns>Difference</returns>
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    /// <summary>
    /// Inheriting the Methods of Parent Class Algebra to Child Class TotalMaths.
    /// </summary>
    class TotalMaths : Algebra
    {
        /// <summary>
        /// This is a Multiplication Method of Two Numbers
        /// </summary>
        /// <param name="a">int A</param>
        /// <param name="b">int B</param>
        /// <returns>Product</returns>
        public int Mul(int a,int b)
            { return a * b; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TotalMaths tm = new TotalMaths();
            Console.WriteLine("\n  -------- Single Inheritance --------\n");
            Console.WriteLine("\n Sum of Two Numbers 4 and 6 is {0}",tm.Add(4,6));
            Console.WriteLine("\n Difference of Two Numbers 4 and 6 is {0}", tm.Sub(4, 6));
            Console.WriteLine("\n Product of Two Numbers 4 and 6 is {0}", tm.Mul(4, 6));

            Console.ReadLine();
        }
    }
}

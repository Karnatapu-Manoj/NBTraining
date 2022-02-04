using System;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code For Multi-Level Inheritance

// for Reference, check Day 10 Project2 in the same Repository
namespace Day10Project2
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
        public int Mul(int a, int b)
        { return a * b; }
    }
    /// <summary>
    /// Inheriting the methods of Parent Class TotalMaths to Child Class OverAllMaths
    /// </summary>
    class OverAllMaths : TotalMaths
    {
        /// <summary>
        /// This is a Division Method of Two Numbers
        /// </summary>
        /// <param name="a">int A</param>
        /// <param name="b">int B</param>
        /// <returns>Division(Quotient)</returns>
        public int Div(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// This is a Modulo-Division Method of Two Numbers
        /// </summary>
        /// <param name="a">int A</param>
        /// <param name="b">int B</param>
        /// <returns>Division(Remainder)</returns>
        public int Mod(int a, int b)
        {
            return a % b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OverAllMaths tm = new OverAllMaths();
            Console.WriteLine("\n  -------- Multi Level Inheritance --------\n");
            Console.WriteLine("\n Sum of Two Numbers 4 and 6 is {0}", tm.Add(4, 6));
            Console.WriteLine("\n Difference of Two Numbers 4 and 6 is {0}", tm.Sub(4, 6));
            Console.WriteLine("\n Product of Two Numbers 4 and 6 is {0}", tm.Mul(4, 6));
            Console.WriteLine("\n Division of Two Numbers 4 and 6 is {0}", tm.Div(4, 6));
            Console.WriteLine("\n Modulos of Two Numbers 4 and 6 is {0}", tm.Mod(4, 6));

            Console.ReadLine();
        }
    }
}

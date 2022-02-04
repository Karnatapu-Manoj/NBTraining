using System;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code for Method Overloading.

namespace Day10Project3
{
    class Mathematics
    {
        /// <summary>
        /// This is an Addition Method of Two Numbers 
        /// </summary>
        /// <param name="a">Int A</param>
        /// <param name="b">Int B</param>
        /// <returns>Sum</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// This is an Addition Method Of Three Numbers
        /// </summary>
        /// <param name="a">Int A</param>
        /// <param name="b">Int B</param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics obj = new Mathematics();
            Console.WriteLine("\n  -------- Method Overloading --------\n");
            Console.WriteLine("Addition of Numbers using two values 5 and 5 is  : {0}",obj.Add(5,5));
            Console.WriteLine("Addition of Numbers using three values 5, 5 and 5 is  : {0}", obj.Add(5,5,5));

            Console.ReadLine();
        }
    }
}

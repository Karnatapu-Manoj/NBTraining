using System;

// Author : Manoj.Karnatapu
// Purpose : Create Mathematics class and add 3 static methods and call the methods in main method.

// for Reference, Check Day11Projct4 in the Same Repository.

namespace Day11Project4
{
    internal class Program
    {
        class Mathematics
        {
            public static int Add(int a, int b)
                { return a + b;}

            public static int Subtract(int a, int b)
                { return a - b;}

            public static int Multiplication(int a, int b)
                { return a * b;}
            public static int Division(int a, int b)
                { return a / b;}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------- Mathematics Class Using Static Methods and Calling ---------\n");
            // Calling Static Methods Using it's Class Name
            Console.WriteLine("\nDoing Addition using static Method       :  {0} ",Mathematics.Add(10,5));
            Console.WriteLine("\nDoing Subtraction using static Method    :  {0} ",Mathematics.Subtract(10,5));
            Console.WriteLine("\nDoing Multiplication using static Method :  {0} ",Mathematics.Multiplication(10, 5));
            Console.WriteLine("\nDoing Division using static Method       :  {0} ",Mathematics.Division(10, 5));

            Console.ReadLine();
        }
    }
}

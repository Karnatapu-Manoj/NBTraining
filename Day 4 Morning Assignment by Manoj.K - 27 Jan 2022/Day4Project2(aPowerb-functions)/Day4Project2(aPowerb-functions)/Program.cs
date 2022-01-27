using System;

// This is a C# Code to find the Power of a number, Using Functions concept
// This Code is Developed by Manoj Karnatapu, on 27 Jan 2022.

namespace Day4Project2_aPowerb_functions_
{
    internal class Program
    {
        public static void PrintOutput(int a, int b)
        {
            Console.WriteLine("{0} power {1} = {2}", a, b, Power(a, b));
        }
        public static int Power(int a, int b)
        {
            int pow = 1;
            for (int i = 1; i <= b; i++)
                pow = pow * a;
            
            return pow;
        }
        static void Main(string[] args)
        {
            int a1 = 4, b1 = 3, a2 = 5, b2 = 4;

            PrintOutput(a1, b1);
            PrintOutput(a2, b2);
            
            Console.ReadLine();
        }
    }
}

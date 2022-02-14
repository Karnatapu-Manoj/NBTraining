using System;

// Author : Manoj.Karnatapu
// Purpose : Creating a Mathematics public class for Reusability Using Partial Class in ManojLibrary.

// For Reference, Check ManojLibrary in Day16Project5 in the same Repository.

namespace ManojLibrary
{
    public static partial class Mathematics
    {
        public static int Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
        public static int Subtraction(int a, int b)
        {
            int diff = a - b;
            Console.WriteLine(diff);
            return diff;
        }
        public static int Multiplication(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine(mul);
            return mul;
        }
        public static int Division(int a, int b)
        {
            int div = a / b;
            Console.WriteLine(div);
            return div;
        }
    }
}

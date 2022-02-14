using System;

// Author : Manoj.Karnatapu
// Purpose : This is a Mathematics Class in <ManojLibrary>

// for Reference, Check Mathematics.cs in ManojLibrary inside ManojKarnatapu Solution.

namespace ManojLibrary
{
    public static class Mathematics
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
        public static int Factorial(int input)
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}

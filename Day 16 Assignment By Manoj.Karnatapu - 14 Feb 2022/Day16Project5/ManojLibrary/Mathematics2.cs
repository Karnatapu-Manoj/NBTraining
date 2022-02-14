using System;

// Author : Manoj.Karnatapu
// Purpose : Creating a Mathematics public class for Reusability Using Partial Class in ManojLibrary.

// For Reference, Check ManojLibrary in Day16Project5 in the same Repository.
namespace ManojLibrary
{
    public static partial class Mathematics
    {
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

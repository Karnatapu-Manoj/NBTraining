using System;
using ManojLibrary;

// Author : Manoj.Karnatapu
// Purpose : Creating a Mathematics public class for Reusability Using Partial Class in ManojLibrary.

// For Reference, Check ManojLibrary in Day16Project5 in the same Repository.
namespace Day16Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Executing Mathematical Operations Using Partial Class \n");

            Console.Write("\nAddition of 5 & 6 is : ");
            Mathematics.Addition(5, 6);
            Console.Write("\nSubtraction of 7 & 3 is : ");
            Mathematics.Subtraction(7, 3);
            Console.Write("\nMultiplication of 8 & 4 is : ");
            Mathematics.Multiplication(8, 4);
            Console.Write("\nDivision of 9 / 5 is : ");
            Mathematics.Division(9, 5);

            Console.WriteLine("\n Factorial of 5 is : {0}",Mathematics.Factorial(5));

            Console.ReadKey();
        }
    }
}

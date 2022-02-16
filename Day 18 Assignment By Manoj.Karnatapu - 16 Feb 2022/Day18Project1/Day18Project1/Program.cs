using System;
using ManojLibrary;

// Author : Manoj.Karnatapu
// Purpose : Creating a Layered Architecture for given Business Requirements In Console Application.

// For Reference, Check Day18Project1 in the same Repository.
namespace Day18Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n Factorial Result is : {0}",Algebra.Factorial(n));

            Console.WriteLine("\n\n Given Number, 131 is Palindrome or Not :  {0}",Algebra.IsPalindrome(131));
            Console.ReadLine();
        }
    }
}

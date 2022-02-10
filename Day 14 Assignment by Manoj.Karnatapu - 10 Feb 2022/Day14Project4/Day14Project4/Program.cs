using System;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code for, Prime Or Not using Break statement.

// for Reference, check Day14Project4 in the same Repository.

namespace Day14Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("Enter any Number to Find Is Prime Or Not :   ");
            n = int.Parse(Console.ReadLine());

            for(i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if(i == n)
                Console.WriteLine("\n Yes, {0} is a Prime Number", n);
            else
                Console.WriteLine("\n No, {0} is Not a Prime Number",n);

            Console.ReadLine();
        }
    }
}

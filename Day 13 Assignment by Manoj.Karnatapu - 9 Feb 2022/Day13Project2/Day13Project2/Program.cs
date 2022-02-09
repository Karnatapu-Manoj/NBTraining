using System;

// Author : Manoj.Karnatapu
// Purpose : Declaring (3x2) 2-D Array in the same line while declaring & Printing the Values using nested for Loops.

// For Reference, check Day13Project2 in the same Repository.
namespace Day13Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initializing & Declaring 2-D Array
            int[,] data = new int[,] { { 5, 6 }, { 7, 8 }, { 9, 10 } };

            // printing the 2-D Array 
            Console.WriteLine("\n ----*** 2-D Array Representation for declaring in same line ****---\n");
            for (int i=0; i < 2;i++)
            {
                for(int j=0; j < 2;j++)
                {
                    Console.Write(data[i,j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}

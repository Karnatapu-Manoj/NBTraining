using System;

// Author : Manoj.Karnatapu
// Purpose : Declaring (2x2) 2-D Array using indexes' & Printing the Value using nested for Loops.

// For Reference, check Day13Project1 in the same Repository.
namespace Day13Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialigation & Declaring 2-D Array using Indexes.
            int[,] data = new int[2, 2];
            data[0, 0] = 15;
            data[0, 1] = 20;
            data[1, 0] = 25;
            data[1, 1] = 30;

            // Printing the 2-D Array, Which is Created.
            Console.WriteLine("\n ---------**** 2-D Array Representation ****---------\n");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}

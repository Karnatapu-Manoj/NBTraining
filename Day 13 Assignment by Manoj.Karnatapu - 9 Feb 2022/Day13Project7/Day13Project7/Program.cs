using System;

// Author : Manoj.Karnatapu
// Purpose : Declaring a jagged array & Printing the value.

// For Reference, Check Day13Project7 in the same repository.

namespace Day13Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring Jagged Array, and initializing.
            char[][] names = new char[4][];
            names[0] = new char[] {'M', 'a', 'n','o', 'j'};
            names[1] = new char[] { 'P', 'a', 'v', 'a', 'n' };
            names[2] = new char[] { 'V', 'i', 'h', 'a', 'r' };
            names[3] = new char[] { 'V', 'i', 'n', 'a', 'y' };

            // Printing The Jagged Array Values.
            Console.WriteLine("\n --------*** Jagged Array Of Names ***--------\n");
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}

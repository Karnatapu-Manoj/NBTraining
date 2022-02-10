using System;

// Author : Manoj.Karnatapu
// Purpose : Printing Numbers from 1 to 30 by skipping, the numbers divisible by 3.

// for Reference, Check Day14Project5 in the same repository.

namespace Day14Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The numbers from 1 -30 by skipping divisible by 3 are   :: \n");
            for (int i = 0;i<=30;i++)
            {
                if (i % 3 == 0)
                    continue;

                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}

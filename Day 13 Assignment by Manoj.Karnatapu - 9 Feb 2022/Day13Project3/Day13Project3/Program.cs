using System;

// Author : Manoj.Karnatapu
// Purpose : Declaring (3x3) 2-D Array & Print the Trace of an Array.

// For Reference, check Day13Project3 in the same Repository.
namespace Day13Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;

            Console.WriteLine("\n Given Array is : \n");
            for (int i = 0;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    Console.Write("\t" + data[i,j] + " ");
                }
                Console.Write("\n");
            }

            for (int i = 0;i<3; i++)
            {
                for(int j = 0;j<3;j++)
                {
                    if(i==j)
                    {
                        sum = sum + data[i,j];
                    }
                }
            }
            Console.WriteLine("\n The Trace of a given array is : {0}",sum);
            Console.ReadLine();
        }
    }
}

using System;
// Author : Manoj.Karnatapu
// Purpose : Declaring (2x2) 2-D Array, Read values from user & Print the Array.

// For Reference, check Day13Project4 in the same Repository.
namespace Day13Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];

            // Reading Array Items from the user
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write($"\n Enter the array item at ({i},{j}) :  ");
                    data[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Printing the Array Values into the Console.
            Console.WriteLine("\n Given Array is : \n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("\t" + data[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
        }
    }
}

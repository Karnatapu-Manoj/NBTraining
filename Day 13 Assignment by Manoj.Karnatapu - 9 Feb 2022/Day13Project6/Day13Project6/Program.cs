using System;

// Author : Manoj.Karnatapu
// Purpose : Declare Two 2-D Arrays of Any symmetrical size,Read values form user & Print Product of Two Matrices.

// For Reference, Check Day13Project6 in the same Repository.
namespace Day13Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, r1, c1, r2, c2, sum = 0;

            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int[,] crr1 = new int[50, 50];

            Console.Write("\n\n\tMultiplication of two Matrices");
            Console.Write("\n-------------------------------------------\n");

            Console.Write("\nInput the number of rows and columns of the first matrix :\n");
            Console.Write("Rows : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput the number of rows of the second matrix :\n");
            Console.Write("Rows : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if (c1 != r2)
            {
                Console.Write("Mutiplication of Matrix is not possible.");
                Console.Write("\nColumn of first matrix and row of second matrix must be same.");
            }
            else
            {
                Console.Write("Enter the Input elements in the first matrix :\n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write($"element - [{i}],[{j}] : ");
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nThe First matrix is :\n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }

                Console.Write("\n\nEnter the Input elements in the second matrix :\n\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nThe Second matrix is :\n");
                for (i = 0; i < r2; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}\t", brr1[i, j]);
                }
                Console.Write("\n");

                //multiplication of matrix
                for (i = 0; i < r1; i++)
                    for (j = 0; j < c2; j++)
                        crr1[i, j] = 0;
                for (i = 0; i < r1; i++)    //row of first matrix
                {
                    for (j = 0; j < c2; j++)    //column of second matrix
                    {
                        sum = 0;
                        for (k = 0; k < c1; k++)
                            sum = sum + arr1[i, k] * brr1[k, j];
                        crr1[i, j] = sum;
                    }
                }
                Console.Write("\nThe multiplication of two matrix is : \n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("{0}\t", crr1[i, j]);
                    }
                }
            }
            Console.Write("\n\n");
        }
    }
}

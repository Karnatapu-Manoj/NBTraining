using System;

//WACP to initialize an array with 5 values and find sum using foreach loop.

namespace Day3Project5_sum_foreach_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Declaration
            int sum = 0;
            int[] data = new int[5];

            //Readng data from the user to store in an Array.
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the {i+1} number :");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Logic for adding items in an Array using foreach
            foreach(int i in data)
            {
                sum = sum + i;
            }

            //Printing sum of items in an Array using foreach
            Console.WriteLine($"The sum of all Items in an array is {sum}");

            Console.ReadLine();
        }
    }
}

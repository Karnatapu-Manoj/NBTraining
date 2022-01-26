using System;

// A C# Code To find Sum of n Natural Numbers. where the value of 'n' is given by the User(Dynamic inputs).

namespace Day2Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration Section
            int input, sum = 0, i;
            
            //Reading Inputs Section
            Console.WriteLine("Enter your Number, to find the sum of the n natural numbers : ");
            input = Convert.ToInt32(Console.ReadLine());

            //Logic Section
            for (i = 1; i <= input; i++)
            { 
                sum = sum + i;
            }

            //Prinitng OutPut Section
            Console.WriteLine($"Sum of first {input} Natural Numbers is : {sum}");

            Console.ReadLine();
        }
    }
}

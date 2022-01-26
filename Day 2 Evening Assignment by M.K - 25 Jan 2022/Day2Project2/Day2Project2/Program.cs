using System;

// A C# code to find the Factorial of a Number, given by the user (Dynamically).

namespace Day2Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration Section
            int input, product = 1, i;

            //Reading Inputs Section
            Console.WriteLine("Enter any number, to find it's Factorial :");
            input = Convert.ToInt32(Console.ReadLine());

            //Program Logic Section
            for(i = 1; i<= input; i++)
            {
                product = product * i;
            }

            //Printing Output to Console Section
            Console.WriteLine($"The Factorial of {input} is : {product}");

            Console.ReadLine();
        }
    }
}

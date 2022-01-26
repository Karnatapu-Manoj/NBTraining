using System;

//A C# code to Print the Factors of a given number by the user Dynamically.

namespace Day2Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration Section
            int input, i;


            //Reading Inputs Section
            Console.WriteLine("Enter any Number, to find it's Factors : ");
            input = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"The Factors for the Given Number {input} are : ");


            //Program Logic & Printing Output Section
            for(i=1; i<=input; i++)
            {
                if(input%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

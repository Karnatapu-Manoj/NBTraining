using System;

// A C# Code To Print Multiplication table for a given number.
namespace Day2Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration Section
            int input, i;
            Console.WriteLine("Which Tabel Number You Want me To Print : ");

            //Reading Inputs Section
            input = Convert.ToInt32(Console.ReadLine());

            //Program Logic Section
            Console.WriteLine("\n::: Displaying Using String Concatination Method :::");
            for (i =1; i <=10; i++)
            {
                //Printing Output using String Concatination
                Console.WriteLine(input + "x" + i + "=" + input*i );
            }

            Console.WriteLine("\n::: Displaying Using String Formating Method :::");
            for(i=1; i <=10; i++)
            {
                //Printing OutPut using String Formating
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            }

            Console.ReadLine();
        }
    }
}

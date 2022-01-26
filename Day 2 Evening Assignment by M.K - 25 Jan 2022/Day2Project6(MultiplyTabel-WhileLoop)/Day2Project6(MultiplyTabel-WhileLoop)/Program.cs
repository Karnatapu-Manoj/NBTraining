using System;

// A C# Code to Display the Multiplacation Table, given by the user(Using While Loop).

namespace Day2Project6_MultiplyTabel_WhileLoop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration Section
            int input, i = 1;
            Console.WriteLine("Which Tabel Number, You Want me To Print :");

            //Reading Inputs Section
            input = Convert.ToInt32(Console.ReadLine());

            //Program Logic Section
            Console.WriteLine("\n::: Displaying Using String Concatination Method :::");
            while (i <= 10)
            {
                //Printing Output using String Concatination
                Console.WriteLine(input + "x" + i + "=" + input * i);
                i++;
            }

            Console.WriteLine("\n::: Displaying Using String Formating Method :::");
            i = 1;
            while (i <= 10)
            {
                //Printing Output using String Formating
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
                i++;
            }

            Console.ReadLine();
        }
    }
}

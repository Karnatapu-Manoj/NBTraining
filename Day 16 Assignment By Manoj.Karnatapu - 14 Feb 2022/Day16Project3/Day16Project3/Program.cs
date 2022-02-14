using System;

// Author : Manoj.Karnatapu
// Purpose : Printing Multiplication table of a given number using Object Oriented Approach.

// For Reference, Check Day16Project3 in the same Repository.
namespace Day16Project3
{
    class MultiplicationTable
    {
        int input;
        /// <summary>
        /// Reading Input Number to Print its Multiplication Table
        /// </summary>
        /// <returns>Entered Number for reference</returns>
        public int ReadInput()
        {

            Console.Write("\n Enter any Number To Print its Multiplication Table : ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n::: Displaying the Multiplication Table for {0} :::\n", input);
            return input;
        }
        /// <summary>
        /// Printing The Multiplication Table for given input number.
        /// </summary>
        public void PrintMulTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                //Printing OutPut using String Formating
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            }

            Console.WriteLine();
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                // Creating Object for a Class as it is not static
                MultiplicationTable table = new MultiplicationTable();
                table.ReadInput();      // calling the ReadInput Method.
                table.PrintMulTable();  // calling the PrintMulTable Method.

                Console.ReadKey();
            }
        }
    }
}